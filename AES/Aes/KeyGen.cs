using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public class KeyGen
    {
        public byte[,] roundkey(byte[,] matrix,int round)
        {
            byte[,] key = (byte[,])matrix.Clone();

            byte[] Rcon = {
                0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40,
                0x80, 0x1B, 0x36, 0x6C, 0xD8, 0xAB, 0x4D, 0x9A,
                0x2F, 0x5E, 0xBC, 0x63, 0xC6, 0x97, 0x35, 0x6A,
                0xD4, 0xB3, 0x7D, 0xFA, 0xEF, 0xC5, 0x91, 0x39,
            };

            byte[,] new_matrix = new byte[4, 4];
            /*
             * w[3] shift
             */
            byte temp = key[0, 3];
            for (int i = 0; i < 3; i++)
            {
                new_matrix[i,0] = key[i + 1, 3];
            }
            new_matrix[3, 0] = temp;


            /*
             * w[3] subbyte
             */
            SubBytes sub = new SubBytes();
            
            for (int i = 0; i < 4; i++)
            {
                new_matrix[i, 0] = sub.Subs(new_matrix[i, 0]);
                
            }

            /*
             * XOR
             */

            new_matrix[0, 0] ^=  Rcon[round];

            for (int i = 0; i < 4; i++)
            {
                new_matrix[i, 0] ^= key[i, 0];
                
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    key[i, j+1] ^= new_matrix[i, j];
                    new_matrix[i, j+1] = key[i, j+1];
                }
            }

            return new_matrix;
        }
    }
}
