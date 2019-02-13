using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public static class ExtString
    {
        public static string RemoveChars (this string _string, params char[] _toRemove)
        {
            string toReturn = "";

            // für jedes Zeichen im Wort
            foreach (char c in _string)
            {
                // für jedes Zeichen welches es zu löschen gilt
                for (int i = 0; i < _toRemove.Length; i++)
                {
                    if (c == _toRemove[i])
                    {
                        break;
                    }
                    if (i == _toRemove.Length - 1)
                    {
                        toReturn += c;
                    }
                }
            }

            return toReturn;
        }
    }
}

namespace Int
{
    public static class ExtInt
    {
        
    }
}

namespace List
{
    public static class ExtList
    {
        public static T GetItemFromBack<T> (this List<T> _list, int _position)
        {
            if (_position >= 0)
            {
                if (_position >= _list.Count)
                    throw new IndexOutOfRangeException($"{_position} has to be lower than {_list.Count}.");
                else
                    return _list[_position];
            }

            int arrayPos = _position + _list.Count;

            if (arrayPos < 0)
                throw new IndexOutOfRangeException($"{arrayPos} must be higher that 0. ||| [({_list.Count}{_position} = {arrayPos})]");

            return _list[_list.Count + _position];
        }
    }
}
