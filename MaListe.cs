using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLINQ
{
    internal class MaListe : IEnumerable<int>
    {
        private MaListEnumerable enumerator;
        public MaListe(int taille)
        {
            enumerator = new MaListEnumerable(taille);
        }
        public IEnumerator<int> GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
