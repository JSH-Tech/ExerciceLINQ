using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLINQ
{
    internal class MaListEnumerable : IEnumerator<int>
    {
        private readonly int taille;
        private int[] tableau;
        private int index = -1;
        public MaListEnumerable(int taille)
        {
            this.taille = taille;
            tableau = new int[taille];

            for (int i = 0; i < taille; i++)
            {
                tableau[i] = i + 1;
            }
        }
        public int Current => tableau[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (index >= taille-1)
            {
                return false;
            }
            index=index + 1;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
