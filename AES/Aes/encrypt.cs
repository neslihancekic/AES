using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace AES
{
    public class en 
    {
        private byte[,] shiftrow(byte[,] s,int round)
        {
            
            if(round<4)
            {
                byte temp = s[round, 0];

                for (int i = 0; i < 3; i++)
                {
                    s[round, i] = s[round, i + 1];
                }
                s[round, 3] = temp;

                round++;
               
                s = shiftrow(s, round);
                if (round == 2)
                {
                    s = shiftrow(s, round);
                    round++;
                    s = shiftrow(s, round);
                }

            }

            return s;
        }

        private byte GMul(byte a, byte b)
        { // Galois Field (256) Multiplication of two Bytes
            byte p = 0;

            for (int counter = 0; counter < 8; counter++)
            {
                if ((b & 1) != 0)
                {
                    p ^= a;
                }

                bool hi_bit_set = (a & 0x80) != 0;
                a <<= 1;
                if (hi_bit_set)
                {
                    a ^= 0x1B; /* x^8 + x^4 + x^3 + x + 1 */
                }
                b >>= 1;
            }

            return p;
        }

        private byte[,] MixColumns(byte[,] s)
        { // 's' is the main State matrix, 'ss' is a temp matrix of the same dimensions as 's'.
            byte[,] ss = new byte[4, 4];

            for (int c = 0; c < 4; c++)
            {
                ss[0, c] = (byte)(GMul(0x02, s[0, c]) ^ GMul(0x03, s[1, c]) ^ s[2, c] ^ s[3, c]);
                ss[1, c] = (byte)(s[0, c] ^ GMul(0x02, s[1, c]) ^ GMul(0x03, s[2, c]) ^ s[3, c]);
                ss[2, c] = (byte)(s[0, c] ^ s[1, c] ^ GMul(0x02, s[2, c]) ^ GMul(0x03, s[3, c]));
                ss[3, c] = (byte)(GMul(0x03, s[0, c]) ^ s[1, c] ^ s[2, c] ^ GMul(0x02, s[3, c]));
            }

            return ss;
        }

       
        public byte[,] addroundkey(byte[,] s, byte[,] k)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    s[i, j] ^= k[i, j];

                }
            }
            return s;
        }
        public byte[,] schedule(byte[,] state,byte[,]rkey)
        {
            KeyGen keyg = new KeyGen();
            SubBytes sbox = new SubBytes();
            /*
             * INITIAL ROUND: Add Round Key
             */
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] ^= rkey[i, j];

                }
            }
            
            /*
             * 9 ROUND
             */
            for (int a = 0; a < 9; a++)
            {
                /*
            * SUBBYTES
            */
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        state[i, j] = sbox.Subs(state[i, j]);

                    }

                }
                /*
                 * SHIFTROW
                 */
                state = shiftrow(state, 1);

                /*
                 * MIXCOLUMN
                 */
                state = MixColumns(state);
               

                /*
                 *ADDROUNDKEY
                 */
               
                rkey = keyg.roundkey(rkey, a);
                state = addroundkey(state, rkey);
            }

            /*
           * SUBBYTES
           */
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] = sbox.Subs(state[i, j]);

                }


            }
            /*
             * SHIFTROW
             */
            state = shiftrow(state, 1);

           

            /*
            *ADDROUNDKEY
            */
           
            rkey = keyg.roundkey(rkey, 9);
            state = addroundkey(state, rkey);

            return state;
        }



    }
}
