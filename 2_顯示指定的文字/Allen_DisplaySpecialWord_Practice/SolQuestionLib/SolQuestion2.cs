using System;
using System.Text;

namespace SolQuestionLib
{
    /// <summary>
    /// 參照題目2截圖
    /// </summary>
    public class SolQuestion2
    {
        // 註解:看起來眼睛就能解?應該不用寫單元測試?
        private string _DefaultNotation = "#"; // 產生圖樣
        private int _UserInputRows = 0; // 產生N列
        private List<string>? Result ; // 暫存N列結果
        private string ErrorMsg = string.Empty;

        public void checkUserInputRows(int rows)
        {
            ErrorMsg = string.Empty;
            //  範圍限制只能在1 <= row <=10，否則一律當作0
            if (rows >= 1 && rows <= 10)
            {
                _UserInputRows = rows;
            }
            else
            {
                // ErrorMsg
                ErrorMsg = $"您輸入的參數{rows}，不滿足1 <= x <= 10的範圍";
                _UserInputRows = 0;
            }
        }
        /// <summary>
        /// 產生井字號的obj
        /// </summary>
        /// <param name="_UserInputRows">要產生幾行的正整數</param>
        public void CreatePoundSign(int row)
        {
            this.checkUserInputRows(row);
            Result = new List<string>();
            for (int i = 0; i < _UserInputRows; i++)
            {
                //第0排0個空白1個字符
                //第1排1個空白1個字符
                //第2排2個空白1個字符
                string NspaceString = new string(' ', i) ;
                string element = NspaceString + _DefaultNotation + "\n";
                if (i != _UserInputRows - 1) {
                    Result.Add(element);
                } else if(i == _UserInputRows - 1) {
                    // 若是最後一圈就加上自己的reverse元素，形成對稱
                    List<string> List2 = new List<string>(Result);
                    List2.Reverse();
                    Result.Add(element);
                    Result.AddRange(List2);
                }
            }
        }
        public string DisplayString() { 
            bool isCountMorThanZero = Result.Count > 0 && Result != null;
            return isCountMorThanZero ? String.Join("", Result.ToArray()) : ErrorMsg;

        }
    }
}