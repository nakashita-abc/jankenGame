namespace BlazorApp1.Entities
{
    public static class JankenData
    {

        public static JankenResult Execute(int clientNum)
        {
            Random random = new Random();
            var result = new JankenResult();
            result.ClientNum = clientNum;
            result.ComputerNum = random.Next(1, 4);


            if (clientNum == 1 & result.ComputerNum == 3)
            {
                result.resultFlg = 2;
            }
            else if (clientNum == 3 & result.ComputerNum == 1)
            {
                result.resultFlg = 1;
            }
            else if (clientNum == result.ComputerNum)
            {
                result.resultFlg = 3;
            }
            else if (clientNum < result.ComputerNum)
            {
                result.resultFlg = 1;
            }
            else
            {
                result.resultFlg = 2;
            }


            switch (result.resultFlg)
            {
                case 1:
                    result.ResultMessage = "WIN！！！";
                    break;
                case 2:
                    result.ResultMessage = "LOSE…";
                    break;
                case 3:
                    result.ResultMessage = "DRAW";
                    break;
            }

            switch (result.ComputerNum)
            {
                case 1:
                    result.ComputerNumName = "グー";
                    break;
                case 2:
                    result.ComputerNumName = "チョキ";
                    break;
                case 3:
                    result.ComputerNumName = "パー";
                    break;
            }


            return result;
        }
    }

    public class JankenResult()
    {
        //勝敗メッセージ
        public string? ResultMessage { get; set; }
        //コンピュータの出す手
        public int? ComputerNum {  get; set; }
        //コンピュータの出す手名称
        public string? ComputerNumName {  get; set; }
        //クライアントの出す手
        public int? ClientNum { get; set; }
        //ジャンケンの勝敗(1:クライアントの勝利　2:コンピュータの勝利　3:引き分け)
        public int? resultFlg {  get; set; }
    }
}
