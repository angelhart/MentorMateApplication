using System;
using System.Text;

namespace MM_Logo.MODELS
{
    public class Logo
    {
        public Logo(int size)
        {
            this.Size = size;
        }

        public int Size { get; }

        private StringBuilder BuildTopHalf(int repetitions = 2)
        {
            var result = new StringBuilder();
            for (int row = 0; row < this.Size / 2; row++)
            {
                for (int repeats = 1; repeats <= repetitions; repeats++)
                {
                    result.Append('-', this.Size - row)
                          .Append('*', this.Size + (row * 2))
                          .Append('-', this.Size - (row * 2))
                          .Append('*', this.Size + (row * 2))
                          .Append('-', this.Size - row);
                }
            }
            return result;
        }

        private StringBuilder BuildBottomHalf(int repetitions = 2)
        {
            var result = new StringBuilder();
            for (int row = (this.Size / 2) + 1; row < this.Size; row++)
            {
                for (int repeats = 1; repeats <= repetitions; repeats++)
                {
                    result.Append('-', this.Size - row)
                          .Append('*', this.Size)
                          .Append('-', (2 * row) - this.Size)
                          .Append('*', (3 * this.Size) - (2 * row))
                          .Append('-', (2 * row) - this.Size)
                          .Append('*', this.Size)
                          .Append('-', this.Size - row);
                }
            }
            return result;
        }

        public override string ToString()
        {
            var output = BuildTopHalf().Append(BuildBottomHalf());
            return output.ToString();
        }

        public string ToString(int repetitions)
        {
            var output = BuildTopHalf(repetitions).Append(BuildBottomHalf(repetitions));
            return output.ToString();
        }
    }
}
