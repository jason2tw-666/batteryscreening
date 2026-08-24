using ClosedXML.Excel;

namespace 電池篩選器
{
    public partial class Form1 : Form
    {
        private List<Battery> allBatteries = new List<Battery>();
        private List<BatteryScore> batteryAllScores = new List<BatteryScore>();
        private List<BatteryScore> battery4100Scores = new List<BatteryScore>();
        private List<BatteryScore> battery5600Scores = new List<BatteryScore>();
        private List<BatteryScore> battery8500Scores = new List<BatteryScore>();

        public Form1()
        {
            InitializeComponent();
        }

        //EXCLE 匯入
        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "選擇電池 Excel";
            openFileDialog.Filter = "Excel 檔案 (*.xlsx;*.xls)|*.xlsx;*.xls";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog.FileName;

            try
            {
                allBatteries = ImportExcel(filePath);

                MessageBox.Show(
                    $"匯入成功！\r\n共讀取 {allBatteries.Count} 顆電池。",
                    "完成",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                textBox2.Text = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Excel 匯入失敗：\r\n{ex.Message}",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //EXCLE匯出路徑
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox3.Text = path.SelectedPath;
        }

        //資料處理
        private void button2_Click(object sender, EventArgs e)
        {
            //檢核資料來源
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("請選擇所有KV值");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("請選擇檔案匯出路徑");
                return;
            }
            if (comboBox1.SelectedItem == comboBox2.SelectedItem ||
                comboBox1.SelectedItem == comboBox3.SelectedItem ||
                comboBox2.SelectedItem == comboBox3.SelectedItem)
            {
                MessageBox.Show("KV值組別不得重複");
                return;
            }

            //第一組KV
            var firstKV = comboBox1.SelectedItem.ToString();
            //第二組KV
            var secondKV = comboBox2.SelectedItem.ToString();
            //第三組KV
            var finallyKV = comboBox3.SelectedItem.ToString();
            //判斷是否要新鮮度處理
            bool TemporalFreshness = checkBox1.Checked;
            //新鮮度處理日期
            DateTime TemporalFreshnessTimes = dateTimePicker1.Value;

            //最終要計算的電池清單
            List<Battery> finalBattery = new List<Battery>();

            //EXCLE匯出路徑
            var toexcel = textBox3.Text;

            double minTime = allBatteries.Min(x => x.DischargeMinutes);//電池庫最小放電時間
            double maxTime = allBatteries.Max(x => x.DischargeMinutes);//電池庫最大放電時間

            double minCapacity = allBatteries.Min(x => x.CapacityMah);//電池庫最小容量
            double maxCapacity = allBatteries.Max(x => x.CapacityMah);//電池庫最大容量

            double minResistance = allBatteries.Min(x => x.InternalResistance);//電池庫最小內阻
            double maxResistance = allBatteries.Max(x => x.InternalResistance);//電池庫最大內阻

            MessageBox.Show($"你輸入的資料如下:\n\r 電池組別排序: {firstKV} -> {secondKV} -> {finallyKV} \n\r 是否需要電池新鮮度排序: {(TemporalFreshness ? "是" : "否")}\n\r ");

            // 電池新鮮度處理
            foreach (var BatteriesOpenDate in allBatteries)
            {
                if (TemporalFreshness)
                {
                    //排除掉USER指定時間
                    if (BatteriesOpenDate.OpenDate >= TemporalFreshnessTimes)
                    {
                        finalBattery.Add(BatteriesOpenDate);
                    }
                }
                else
                {
                    //不排除掉時間
                    finalBattery.Add(BatteriesOpenDate);
                }
            }

            var profiles = new[]
                {
                    new KvProfile
                    {
                        // 內組>放電時間>容量
                        Kv = 4100,
                        TimeWeight = 0.30,
                        CapacityWeight = 0.20,
                        ResistanceWeight = 0.50
                    },

                    new KvProfile
                    {
                         // 內組>容量>放電時間
                        Kv = 5600,
                        TimeWeight = 0.20,
                        CapacityWeight = 0.35,
                        ResistanceWeight = 0.45
                    },

                    new KvProfile
                    {
                        // 放電時間>容量>內組
                        Kv = 8500,
                        TimeWeight = 0.50,
                        CapacityWeight = 0.30,
                        ResistanceWeight = 0.20
                    }
                };

            foreach (var profile in profiles)
            {
                MessageBox.Show($"正在計算 組別:{profile.Kv}Kv 匹配率");

                List<BatteryScore> batteryScores = new List<BatteryScore>();

                foreach (var battery in allBatteries)
                {
                    double timeScore =
                                (battery.DischargeMinutes - minTime)
                                / (maxTime - minTime);

                    double capacityScore =
                        (battery.CapacityMah - minCapacity)
                        / (maxCapacity - minCapacity);

                    double resistanceScore =
                        (maxResistance - battery.InternalResistance)
                        / (maxResistance - minResistance);

                    double finalScore =
                        timeScore * profile.TimeWeight
                        + capacityScore * profile.CapacityWeight
                        + resistanceScore * profile.ResistanceWeight;

                    batteryScores.Add(new BatteryScore
                    {
                        type = profile.Kv,
                        Battery = battery,
                        Score = finalScore
                    });

                    batteryAllScores.Add(new BatteryScore
                    {
                        type = profile.Kv,
                        Battery = battery,
                        Score = finalScore
                    });
                }

                // 由高到低排序
                var sorted = batteryScores
                    .OrderByDescending(x => x.Score)
                    .ToList();

                MessageBox.Show($"計算完成 \r\n " +
                    $"提供電池數 [{allBatteries.Count}]\r\n " +
                    $"組別:[ {profile.Kv}Kv]\r\n  " +
                    $"最高匹配率:[ {sorted.Max(x => x.Score)} ]\r\n  " +
                    $"最低匹配率:[ {sorted.Min(x => x.Score)} ]");

                //輸出給前端使用
                switch (profile.Kv)
                {
                    case 4100:
                        textBox1.Text = sorted.Max(x => x.Score).ToString();
                        textBox6.Text = sorted.Min(x => x.Score).ToString();
                        comboBox4.Items.Clear();
                        comboBox4.Items.AddRange(sorted.Select(x => $"{x.Battery.BatteryId} : {x.Score:F4}").ToArray());
                        break;

                    case 5600:
                        textBox4.Text = sorted.Max(x => x.Score).ToString();
                        textBox7.Text = sorted.Min(x => x.Score).ToString();
                        comboBox5.Items.Clear();
                        comboBox5.Items.AddRange(sorted.Select(x => $"{x.Battery.BatteryId} : {x.Score:F4}").ToArray());
                        break;

                    case 8500:
                        textBox5.Text = sorted.Max(x => x.Score).ToString();
                        textBox8.Text = sorted.Min(x => x.Score).ToString();
                        comboBox6.Items.Clear();
                        comboBox6.Items.AddRange(sorted.Select(x => $"{x.Battery.BatteryId} : {x.Score:F4}").ToArray());
                        break;
                }
            }
        }

        //EXCLE 匯入資料處理
        private List<Battery> ImportExcel(string fromExcel)
        {
            var batteries = new List<Battery>();

            var batteryIds = new HashSet<string>();

            using var workbook = new XLWorkbook(fromExcel);

            var worksheet = workbook.Worksheet(1);

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                var batteryId = row.Cell(1).GetString();

                if (!batteryIds.Add(batteryId))
                {
                    throw new Exception($" 重複電池名稱，請重新選擇: \r\n 重複名稱:{batteryId}");
                }
                var battery = new Battery
                {
                    BatteryId = row.Cell(1).GetString(),

                    OpenDate = row.Cell(2).GetDateTime(),

                    DischargeMinutes = row.Cell(3).GetDouble(),

                    CapacityMah = row.Cell(4).GetDouble(),

                    InternalResistance = row.Cell(5).GetDouble()
                };

                batteries.Add(battery);
            }
            return batteries;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //檢核資料來源
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("請選擇所有KV值");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("請選擇檔案匯出路徑");
                return;
            }

            DateTime datetime = DateTime.Now;

            //第一組KV
            string firstKV = comboBox1.SelectedItem.ToString();
            //第二組KV
            string secondKV = comboBox2.SelectedItem.ToString();
            //第三組KV
            string finallyKV = comboBox3.SelectedItem.ToString();
            //包成優先順序的List
            var batteryorder = new List<string> { firstKV, secondKV, finallyKV };
            // 單組別最大上限
            int AllgroupSize = int.Parse(comboBox7.SelectedItem.ToString()) * 4;

            //EXCE 頁籤
            List<BatteryScore> battery4100list = new List<BatteryScore>();
            //EXCE 頁籤
            List<BatteryScore> battery5600list = new List<BatteryScore>();
            //EXCE 頁籤
            List<BatteryScore> battery8500list = new List<BatteryScore>();

            // 每組的電池數量
            int groupSize = 4;

            double.TryParse(textBox9.Text, out double ToleranceValue4100);

            double.TryParse(textBox10.Text, out double ToleranceValue5600);

            double.TryParse(textBox11.Text, out double ToleranceValue8500);

            double maxScore = batteryAllScores.Max(x => x.Score);
            double minScore = batteryAllScores.Min(x => x.Score);

            //if (ToleranceValue4100 >= maxScore || ToleranceValue4100 <= minScore ||
            //    ToleranceValue5600 >= maxScore || ToleranceValue5600 <= minScore ||
            //    ToleranceValue8500 >= maxScore || ToleranceValue8500 <= minScore)
            //{
            //    MessageBox.Show($"請重新輸入寬容值，已超出參數或是低於\r\n 最大值:\r\n{maxScore}, 最小值: {minScore}");
            //    return;
            //}

            //開始組別匹配
            foreach (var Match in batteryorder)
            {
                string type = "";
                //判斷組別優先順序
                if (Match == "4100KV")
                {
                    type = "4100";
                }
                else if (Match == "5600KV")
                {
                    type = "5600";
                }
                else if (Match == "8500KV")
                {
                    type = "8500";
                }
                else if (Match == "4100KV" || Match == "5600KV" || Match == "8500KV")
                {
                    type = Match;
                }

                switch (type)
                {
                    case "4100":
                        battery4100list.AddRange(GetMatchDetails(type, groupSize, AllgroupSize, ToleranceValue4100));

                        break;

                    case "5600":
                        battery5600list.AddRange(GetMatchDetails(type, groupSize, AllgroupSize, ToleranceValue5600));
                        break;

                    case "8500":

                        battery8500list.AddRange(GetMatchDetails(type, groupSize, AllgroupSize, ToleranceValue8500));
                        break;
                }
            }

            byte[] dataByte1 = ExportToExcel(battery4100list, battery5600list, battery8500list);
            File.WriteAllBytes($@"{textBox3.Text}\電池整理-{datetime:yyyyMMddHHmmss}.xlsx", dataByte1);
            MessageBox.Show($"檔案匯出完成 \r\n 路徑: {textBox3.Text}\\電池整理-{datetime:yyyyMMddHHmmss}.xlsx");
        }

        private List<BatteryScore> GetMatchDetails(string type, int groupSize, int AllgroupSize, double ToleranceValue)
        {
            List<BatteryScore> Details = new List<BatteryScore>();
            try
            {
                while (batteryAllScores.Count >= 4 &&
                       Details.Count < AllgroupSize)
                {
                    List<BatteryScore> bestGroup = null;
                    double bestDifference = double.MaxValue;
                    double bestAverageScore = double.MinValue;

                    // 找符合條件的 4 顆
                    for (int i = 0; i <= batteryAllScores.Count - 4; i++)
                    {
                        var group = batteryAllScores
                            .Skip(i)
                            .Take(4)
                            .ToList();

                        double maxScore = group.Max(x => x.Score);
                        double minScore = group.Min(x => x.Score);

                        double difference = maxScore - minScore;
                        double averageScore = group.Average(x => x.Score);

                        // 必須先符合 ToleranceValue
                        if (difference > ToleranceValue)
                            continue;

                        // 優先選平均分數最高的組
                        // 如果平均分數相同，再選差距最小的
                        if (averageScore > bestAverageScore ||
                            (averageScore == bestAverageScore &&
                             difference < bestDifference))
                        {
                            bestAverageScore = averageScore;
                            bestDifference = difference;
                            bestGroup = group;
                        }
                    }

                    // 沒有任何符合 ToleranceValue 的 4 顆
                    if (bestGroup == null)
                    {
                        break;
                    }

                    string Batterygroup = "";

                    double maxScoreBest = bestGroup.Max(x => x.Score);
                    double minScoreBest = bestGroup.Min(x => x.Score);

                    foreach (var item in bestGroup)
                    {
                        Console.WriteLine(
                            $"{item.Battery.BatteryId} : {item.Score:F4}");

                        Batterygroup +=
                            $"[{type}KV-{item.Battery.BatteryId} : {item.Score:F4}]\r\n";

                        Details.Add(item);
                    }

                    // 從剩餘清單移除
                    foreach (var item in bestGroup)
                    {
                        batteryAllScores.RemoveAll(b =>
                            b.Battery.BatteryId == item.Battery.BatteryId);
                    }

                    MessageBox.Show(
                        $"計算完成\r\n" +
                        $"提供電池數 [{allBatteries.Count}]\r\n" +
                        $"最高匹配率: [{maxScoreBest:F4}]\r\n" +
                        $"最低匹配率: [{minScoreBest:F4}]\r\n" +
                        $"差異: [{bestDifference:F4}]\r\n" +
                        $"平均分數: [{bestAverageScore:F4}]\r\n\r\n" +
                        $"{Batterygroup}"
                    );
                }

                return Details;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}");
                return Details;
            }
        }

        public byte[] ExportToExcel(
                                       List<BatteryScore> battery4100list,
                                       List<BatteryScore> battery5600list,
                                       List<BatteryScore> battery8500list)

        {
            using var workbook = new XLWorkbook();

            AddWorksheet(workbook, battery4100list, "4100KV");
            AddWorksheet(workbook, battery5600list, "5600KV");
            AddWorksheet(workbook, battery8500list, "8500KV");

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);

            return stream.ToArray();
        }

        protected void AddWorksheet(XLWorkbook workbook,
                                      List<BatteryScore> batteries,
                                      string sheetName)
        {
            var worksheet = workbook.Worksheets.Add(sheetName);

            worksheet.Cell(1, 1).Value = $@"電池編號";
            worksheet.Cell(1, 2).Value = $@"匹配率";
            worksheet.Cell(1, 3).Value = $@"內阻";
            worksheet.Cell(1, 4).Value = $@"容量";
            worksheet.Cell(1, 5).Value = $@"放電時間";
            worksheet.Cell(1, 6).Value = $@"電池組別";

            int groupS = 4;
            int groupSname = 0;

            for (int i = 0; i < batteries.Count; i++)
            {
                var battery = batteries[i];

                if (groupS >= 4)
                {
                    groupSname += 1;
                    // 在每組 4 顆電池之後插入分隔線
                    worksheet.Cell(i + 2, 6).Value = $"-----組別{groupSname}組------";
                    groupS = 0; // 重置計數器
                }

                worksheet.Cell(i + 2, 1).Value = battery.Battery.BatteryId;
                worksheet.Cell(i + 2, 2).Value = battery.Score;
                worksheet.Cell(i + 2, 3).Value = $"{battery.Battery.InternalResistance} Ω";
                worksheet.Cell(i + 2, 4).Value = $"{battery.Battery.CapacityMah} mah";
                worksheet.Cell(i + 2, 5).Value = battery.Battery.DischargeMinutes;

                groupS += 1;
            }

            worksheet.Columns().AdjustToContents();
        }
    }
}