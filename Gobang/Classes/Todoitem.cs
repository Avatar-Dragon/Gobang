using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobang.Classes
{
    public class TodoItem : ViewModelBase
    {
        // 保存时间
        private string Data;
        public string data { get { return this.Data; } set { Set(ref Data, value); } }

        // 玩家评论
        private string Description;
        public string description { get { return this.Description; } set { Set(ref Description, value); } }

        private string Winner;
        public string winner { get { return this.Winner; } set { Set(ref Winner, value); } }

        private int[,] SaveMatrix;
        public int[,] saveMatrix { get { return this.SaveMatrix; } set { Set(ref SaveMatrix, value); } }
        public TodoItem(string data = "2016-5-13", string description = "", string winner = "", int[,] saveMatrix = null)
        {
            this.data = data;
            this.description = description;
            this.saveMatrix = saveMatrix;
            this.winner = winner;
            if (this.saveMatrix == null)
            {
                this.saveMatrix = new int[MainPage.matrixWidth, MainPage.matrixWidth];
                for (int i = 0; i < MainPage.matrixWidth; i++)
                {
                    for (int j = 0; j < MainPage.matrixWidth; j++)
                    {
                        this.saveMatrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
