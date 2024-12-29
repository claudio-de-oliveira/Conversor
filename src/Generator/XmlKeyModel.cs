namespace Conversor.Generator;

public class XmlKeyModel
{
    public int LevelIndex { get; set; }
    public int GroupIndex { get; set; }
    public int InGroupIndex { get; set; }
    public int InGroupJoinedIndex { get; set; }

    public string Key { get; set; } = "";

    public static bool TryParse(string line, out XmlKeyModel? model)
    {
        int state = 0;
        string lexema = string.Empty;
        int position = 0;
        int lIndex = -1;
        int gIndex = -1;
        int iIndex = -1;
        int sIndex = -1;

        string text = line + '#';

        while(true)
        {
            switch(state)
            {
                case 0:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 0;
                        position++;
                        break;
                    }
                    if (text[position] == '[')
                    {
                        state = 1;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 1:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 1;
                        position++;
                        break;
                    }
                    if (text[position] == 'L' || text[position] == 'l')
                    {
                        state = 2;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 2:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 2;
                        position++;
                        break;
                    }
                    if (char.IsDigit(text[position]))
                    {
                        lexema = "" + text[position];
                        state = 3;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 3:
                    if (char.IsDigit(text[position]))
                    {
                        lexema += text[position];
                        state = 3;
                        position++;
                        break;
                    }
                    state = 4;
                    position++;
                    break;

                case 4:
                    lIndex = int.Parse(lexema);
                    state = 5;
                    break;

                case 5:
                    position--; // RETRACT
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 5;
                        position++;
                        break;
                    }
                    if (text[position] == 'G' || text[position] == 'g')
                    {
                        state = 6;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 6:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 6;
                        position++;
                        break;
                    }
                    if (char.IsDigit(text[position]))
                    {
                        lexema = "" + text[position];
                        state = 7;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 7:
                    if (char.IsDigit(text[position]))
                    {
                        lexema += text[position];
                        state = 7;
                        position++;
                        break;
                    }
                    state = 8;
                    position++;
                    break;

                case 8:
                    gIndex = int.Parse(lexema);
                    state = 9;
                    break;

                case 9:
                    position--; // RETRACT
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 9;
                        position++;
                        break;
                    }
                    if (text[position] == 'I' || text[position] == 'i')
                    {
                        state = 10;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 10:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 10;
                        position++;
                        break;
                    }
                    if (char.IsDigit(text[position]))
                    {
                        lexema = "" + text[position];
                        state = 11;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 11:
                    if (char.IsDigit(text[position]))
                    {
                        lexema += text[position];
                        state = 11;
                        position++;
                        break;
                    }
                    state = 12;
                    position++;
                    break;

                case 12:
                    iIndex = int.Parse(lexema);
                    state = 13;
                    break;

                case 13:
                    position--; // RETRACT
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 13;
                        position++;
                        break;
                    }
                    if (text[position] == ']')
                    {
                        state = 18;
                        position++;
                        break;
                    }
                    if (text[position] == 'S' || text[position] == 's')
                    {
                        state = 14;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 14:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 14;
                        position++;
                        break;
                    }
                    if (char.IsDigit(text[position]))
                    {
                        lexema = "" + text[position];
                        state = 15;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 15:
                    if (char.IsDigit(text[position]))
                    {
                        lexema += text[position];
                        state = 15;
                        position++;
                        break;
                    }
                    state = 16;
                    position++;
                    break;

                case 16:
                    sIndex = int.Parse(lexema);
                    state = 17;
                    break;

                case 17:
                    position--; // RETRACT
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 17;
                        position++;
                        break;
                    }
                    if (text[position] == ']')
                    {
                        state = 18;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 18:
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 18;
                        position++;
                        break;
                    }
                    if (char.IsLetter(text[position]))
                    {
                        lexema = "" + text[position];
                        state = 19;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 19:
                    if (char.IsLetterOrDigit(text[position]))
                    {
                        lexema += text[position];
                        state = 19;
                        position++;
                        break;
                    }
                    state = 20;
                    position++;
                    break;

                case 20:
                    position--; // RETRACT
                    if (char.IsWhiteSpace(text[position]))
                    {
                        state = 20;
                        position++;
                        break;
                    }
                    if (text[position] == '#')
                    {
                        state = 21;
                        position++;
                        break;
                    }
                    state = 99;
                    position++;
                    break;

                case 21:
                    model = new XmlKeyModel
                    {
                        LevelIndex = lIndex,
                        GroupIndex = gIndex,
                        InGroupIndex = iIndex,
                        InGroupJoinedIndex = sIndex,
                        Key = lexema
                    };
                    return true;


                case 99:
                    model = null;
                    return false;
            }

        }

    }
}