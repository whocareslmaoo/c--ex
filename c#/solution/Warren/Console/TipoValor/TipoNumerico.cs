using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor1
{
    internal class TipoNumerico
    {   
        public void Executa2()
        {
            byte byteMin = Byte.MinValue;
            byte byteMax = Byte.MaxValue;

            System.Console.WriteLine("minimo"+byteMin);
            System.Console.WriteLine("maximo"+byteMax);

            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("Sbyte min:" + sbyteMin);
            System.Console.WriteLine("Sbyte max:" + sbyteMax);

            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("Short min:" + shortMin);
            System.Console.WriteLine("Short max:" + shortMax);

            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("uShort min:" + ushortMin);
            System.Console.WriteLine("uShort max:" + ushortMax);

            //Int16 - 16 bits similar ao short
            //Int32
            //Int64
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("Int min: "+intMin);
            System.Console.WriteLine("Int max: " + intMax);

            uint uintMin = uint.MinValue;
            uint uintMax = uint.MaxValue;
            System.Console.WriteLine("uInt min: " + uintMin);
            System.Console.WriteLine("uInt max: " + uintMax);

            


        }
    }
}
