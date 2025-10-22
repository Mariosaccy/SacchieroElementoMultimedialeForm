using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroElementoMultimediale
{
    public interface IVolumeRegolabile
    {
        int Volume { get; set; }
        void Weaker();
        void Louder();
    }

    public interface ILuminositaRegolabile
    {
        int Luminosita { get; set; }
        void Brighter();
        void Darker();
    }
}
