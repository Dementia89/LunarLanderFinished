using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
    public class Font
    {
        public LinkedList<Vector2> sentence = new LinkedList<Vector2>();
        public string sentenceInput;

        float b;
        int offset = 0;
        Vector2 position = new Vector2(10,10);

        public Font(string a, float bb)
        {
            b = bb;
            sentenceInput = a;
            offset = 0;
            foreach(char c in sentenceInput)
            {
                if (c == 97 || c == 65)
                {
                    GetLetterA(b);
                    offset += 3;
                }

                if (c == 98 || c == 66)
                {
                    GetLetterB(b);
                    offset += 3;
                }

                if (c == 99 || c == 67)
                {
                    GetLetterC(b);
                    offset += 3;
                }

                if (c == 100 || c == 68)
                {
                    GetLetterD(b);
                    offset += 3;
                }

                if (c == 101 || c == 69)
                {
                    GetLetterE(b);
                    offset += 3;
                }

                if (c == 102 || c == 70)
                {
                    GetLetterF(b);
                    offset += 3;
                }

                if (c == 103 || c == 71)
                {
                    GetLetterG(b);
                    offset += 3;
                }

                if (c == 104 || c == 72)
                {
                    GetLetterH(b);
                    offset += 3;
                }

                if (c == 105 || c == 73)
                {
                    GetLetterI(b);
                    offset +=3;
                }

                if (c == 106 || c == 74)
                {
                    GetLetterJ(b);
                    offset += 3;
                }

                if (c == 107 || c == 75)
                {
                    GetLetterK(b);
                    offset += 3;
                }

                if (c == 108 || c == 76)
                {
                    GetLetterL(b);
                    offset += 3;
                }

                if (c == 109 || c == 77)
                {
                    GetLetterM(b);
                    offset += 3;
                }

                if (c == 110 || c == 78)
                {
                    GetLetterN(b);
                    offset += 3;
                }

                if (c == 111 || c == 79)
                {
                    GetLetterO(b);
                    offset += 3;
                }

                if (c == 112 || c == 80)
                {
                    GetLetterP(b);
                    offset += 3;
                }

                if (c == 113 || c == 81)
                {
                    GetLetterQ(b);
                    offset += 3;
                }

                if (c == 114 || c == 82)
                {
                    GetLetterR(b);
                    offset += 3;
                }

                if (c == 115 || c == 83)
                {
                    GetLetterS(b);
                    offset += 3;
                }

                if (c == 116 || c == 84)
                {
                    GetLetterT(b);
                    offset += 3;
                }

                if (c == 117 || c == 85)
                {
                    GetLetterU(b);
                    offset += 3;
                }

                if (c == 118 || c == 86)
                {
                    GetLetterV(b);
                    offset += 3;
                }

                if (c == 119 || c == 87)
                {
                    GetLetterW(b);
                    offset += 3;
                }

                if (c == 120 || c == 88)
                {
                    GetLetterX(b);
                    offset += 3;
                }

                if (c == 121 || c == 89)
                {
                    GetLetterY(b);
                    offset += 3;
                }

                if (c == 122 || c == 90)
                {
                    GetLetterZ(b);
                    offset += 3;
                }

                if (c == 49)
                {
                    GetNumberOne(b);
                    offset += 3;
                }

                if (c == 50)
                {
                    GetNumberTwo(b);
                    offset += 3;
                }

                if (c == 51)
                {
                    GetNumberThree(b);
                    offset += 3;
                }

                if (c == 52)
                {
                    GetNumberFour(b);
                    offset += 3;
                }

                if (c == 53)
                {
                    GetNumberFive(b);
                    offset += 3;
                }

                if (c == 54)
                {
                    GetNumberSix(b);
                    offset += 3;
                }

                if (c == 55)
                {
                    GetNumberSeven(b);
                    offset += 3;
                }

                if (c == 56)
                {
                    GetNumberEight(b);
                    offset += 3;
                }

                if (c == 57)
                {
                    GetNumberNine(b);
                    offset += 3;
                }

                if (c == 48)
                {
                    GetNumberZero(b);
                    offset += 3;
                }

                if (c == 46)
                {
                    GetPeriod(b);
                    offset += 3;
                }

                if (c == 32)
                {
                    offset += 3;
                }
            }
        }
        
        public void Update(string update)
        {
            sentence.Clear();
            offset = 0;
            sentenceInput = update;
            foreach (char c in sentenceInput)
            {
                if (c == 97 || c == 65)
                {
                    GetLetterA(b);
                    offset += 3;
                }

                if (c == 98 || c == 66)
                {
                    GetLetterB(b);
                    offset += 3;
                }

                if (c == 99 || c == 67)
                {
                    GetLetterC(b);
                    offset += 3;
                }

                if (c == 100 || c == 68)
                {
                    GetLetterD(b);
                    offset += 3;
                }

                if (c == 101 || c == 69)
                {
                    GetLetterE(b);
                    offset += 3;
                }

                if (c == 102 || c == 70)
                {
                    GetLetterF(b);
                    offset += 3;
                }

                if (c == 103 || c == 71)
                {
                    GetLetterG(b);
                    offset += 3;
                }

                if (c == 104 || c == 72)
                {
                    GetLetterH(b);
                    offset += 3;
                }

                if (c == 105 || c == 73)
                {
                    GetLetterI(b);
                    offset += 3;
                }

                if (c == 106 || c == 74)
                {
                    GetLetterJ(b);
                    offset += 3;
                }

                if (c == 107 || c == 75)
                {
                    GetLetterK(b);
                    offset += 3;
                }

                if (c == 108 || c == 76)
                {
                    GetLetterL(b);
                    offset += 3;
                }

                if (c == 109 || c == 77)
                {
                    GetLetterM(b);
                    offset += 3;
                }

                if (c == 110 || c == 78)
                {
                    GetLetterN(b);
                    offset += 3;
                }

                if (c == 111 || c == 79)
                {
                    GetLetterO(b);
                    offset += 3;
                }

                if (c == 112 || c == 80)
                {
                    GetLetterP(b);
                    offset += 3;
                }

                if (c == 113 || c == 81)
                {
                    GetLetterQ(b);
                    offset += 3;
                }

                if (c == 114 || c == 82)
                {
                    GetLetterR(b);
                    offset += 3;
                }

                if (c == 115 || c == 83)
                {
                    GetLetterS(b);
                    offset += 3;
                }

                if (c == 116 || c == 84)
                {
                    GetLetterT(b);
                    offset += 3;
                }

                if (c == 117 || c == 85)
                {
                    GetLetterU(b);
                    offset += 3;
                }

                if (c == 118 || c == 86)
                {
                    GetLetterV(b);
                    offset += 3;
                }

                if (c == 119 || c == 87)
                {
                    GetLetterW(b);
                    offset += 3;
                }

                if (c == 120 || c == 88)
                {
                    GetLetterX(b);
                    offset += 3;
                }

                if (c == 121 || c == 89)
                {
                    GetLetterY(b);
                    offset += 3;
                }

                if (c == 122 || c == 90)
                {
                    GetLetterZ(b);
                    offset += 3;
                }

                if (c == 49)
                {
                    GetNumberOne(b);
                    offset += 3;
                }

                if (c == 50)
                {
                    GetNumberTwo(b);
                    offset += 3;
                }

                if (c == 51)
                {
                    GetNumberThree(b);
                    offset += 3;
                }

                if (c == 52)
                {
                    GetNumberFour(b);
                    offset += 3;
                }

                if (c == 53)
                {
                    GetNumberFive(b);
                    offset += 3;
                }

                if (c == 54)
                {
                    GetNumberSix(b);
                    offset += 3;
                }

                if (c == 55)
                {
                    GetNumberSeven(b);
                    offset += 3;
                }

                if (c == 56)
                {
                    GetNumberEight(b);
                    offset += 3;
                }

                if (c == 57)
                {
                    GetNumberNine(b);
                    offset += 3;
                }

                if (c == 48)
                {
                    GetNumberZero(b);
                    offset += 3;
                }

                if (c == 46)
                {
                    GetPeriod(b);
                    offset += 3;
                }

                if (c == 32)
                {
                    offset += 3;
                }
            }
        }

        LinkedList<Vector2> GetLetterA(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterB(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterC(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterD(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterE(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterF(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterG(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            
            return sentence;
        }

        LinkedList<Vector2> GetLetterH(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterI(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterJ(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterK(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterL(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterM(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterN(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterO(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterP(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterQ(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterR(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterS(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterT(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterU(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterV(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterW(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterX(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterY(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetLetterZ(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberOne(float scale)
        {
            sentence.AddLast(new Vector2((1 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberTwo(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberThree(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberFour(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberFive(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberSix(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberSeven(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberEight(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberNine(float scale)
        {
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetNumberZero(float scale)
        {
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 0 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((0 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((0 + offset) * scale, 0 * scale));

            return sentence;
        }

        LinkedList<Vector2> GetPeriod(float scale)
        {
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 1 * scale));
            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((2 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));

            sentence.AddLast(new Vector2((1 + offset) * scale, 2 * scale));
            sentence.AddLast(new Vector2((1 + offset) * scale, 1 * scale));

            return sentence;
        }
    }
}
