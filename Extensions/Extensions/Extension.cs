﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StringExtensions
{
    /// <summary>
    /// Extensions for System.String
    /// </summary>
    public static class ExtString
    {
        /// <summary>
        /// Removes chars in string.
        /// </summary>
        /// <param name="_string">The string.</param>
        /// <param name="_toRemove">Chars to remove.</param>
        /// <returns>new string without given chars</returns>
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

namespace IntExtensions
{
    /// <summary>
    /// Extensions for System.Int32
    /// </summary>
    public static class ExtInt
    {
        
    }
}

namespace ListExtensions
{
    /// <summary>
    /// Extensions for System.Collections.Generic.List
    /// </summary>
    public static class ExtList
    {
        /// <summary>
        /// Gets the item from back.
        /// </summary>
        /// <example>
        /// _list.GetItemFromBack(-1) --> return the last Item in List;
        /// </example>
        /// <typeparam name="T">Type of List</typeparam>
        /// <param name="_list">The list where the Items is located.</param>
        /// <param name="_position">position of Item. (-1 --> last item of list)</param>
        /// <returns>Item at given position</returns>
        /// <exception cref="IndexOutOfRangeException">
        /// </exception>
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

namespace ArrayExtensions
{
    /// <summary>
    /// Extensions for System.Array
    /// </summary>
    public static class ExtArray
    {
        /// <summary>
        /// Gets the item from back.
        /// </summary>
        /// <example>
        /// _list.GetItemFromBack(-1) --> return the last Item in List;
        /// </example>
        /// <typeparam name="T">Type of List</typeparam>
        /// <param name="_array">The list where the Items is located.</param>
        /// <param name="_position">position of Item. (-1 --> last item of list)</param>
        /// <returns>Item at given position</returns>
        /// <exception cref="IndexOutOfRangeException">
        /// </exception>
        public static T GetItemFromBack<T>(this T[] _array, int _position)
        {
            if (_position >= 0)
            {
                if (_position >= _array.Length)
                    throw new IndexOutOfRangeException($"{_position} has to be lower than {_array.Length}.");
                else
                    return _array[_position];
            }
            
            int arrayPos = _position + _array.Length;
            
            if (arrayPos < 0)
                throw new IndexOutOfRangeException($"{arrayPos} must be higher that 0. ||| [({_array.Length}{_position} = {arrayPos})]");
            
            return _array[_array.Length + _position];
        }


    }
}

namespace FloatExtensions
{
    /// <summary>
    /// Extensions for System.Single (float)
    /// </summary>
    public static class ExtFloat
    {
        /// <summary>
        /// check if two values are in range
        /// </summary>
        /// <param name="_pos1">first position</param>
        /// <param name="_pos2">second position</param>
        /// <param name="_distance">allowed distance</param>
        /// <returns><c>true</c>: both positions are in range; else <c>false</c></returns>
        public static bool IsInRange(this float _pos1, float _pos2, float _distance)
        {
            if (_pos1 + _distance >= _pos2 &&
                _pos1 - _distance <= _pos2)
                return true;
            else
                return false;
        }
    }
}

namespace Unity
{
    /// <summary>
    /// Extensions for Unity
    /// </summary>
    public static class ExtVector3
    {
        /// <summary>
        /// Check if two positions are in range
        /// </summary>
        /// <param name="_pos1">first position</param>
        /// <param name="_pos2">secons position</param>
        /// <param name="_distance">allowed distance</param>
        /// <returns><c>true</c>: both positions are in range; else <c>false</c></returns>
        public static bool IsInRange(this Vector3 _pos1, Vector3 _pos2, float _distance)
        {
            if (
                FloatExtensions.ExtFloat.IsInRange(
                    _pos1.x, 
                    _pos2.x, 
                    _distance) &&
                    FloatExtensions.ExtFloat.IsInRange(
                        _pos1.y,
                        _pos2.y,
                        _distance) &&
                        FloatExtensions.ExtFloat.IsInRange(
                            _pos1.z,
                            _pos2.z,
                            _distance)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if two positions are in range. Ignores X Position
        /// </summary>
        /// <param name="_pos1">first position</param>
        /// <param name="_pos2">secons position</param>
        /// <param name="_distance">allowed distance</param>
        /// <returns><c>true</c>: both positions are in range; else <c>false</c></returns>
        public static bool IsInRangeNoX(this Vector3 _pos1, Vector3 _pos2, float _distance)
        {
            if (
                FloatExtensions.ExtFloat.IsInRange(
                    _pos1.y,
                    _pos2.y,
                    _distance) &&
                    FloatExtensions.ExtFloat.IsInRange(
                        _pos1.z,
                        _pos2.z,
                        _distance)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if two positions are in range. Ignores Y Position
        /// </summary>
        /// <param name="_pos1">first position</param>
        /// <param name="_pos2">secons position</param>
        /// <param name="_distance">allowed distance</param>
        /// <returns><c>true</c>: both positions are in range; else <c>false</c></returns>
        public static bool IsInRangeNoY(this Vector3 _pos1, Vector3 _pos2, float _distance)
        {
            if (
                FloatExtensions.ExtFloat.IsInRange(
                    _pos1.x,
                    _pos2.x,
                    _distance) &&
                    FloatExtensions.ExtFloat.IsInRange(
                        _pos1.z,
                        _pos2.z,
                        _distance)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if two positions are in range. Ignores Z Position
        /// </summary>
        /// <param name="_pos1">first position</param>
        /// <param name="_pos2">secons position</param>
        /// <param name="_distance">allowed distance</param>
        /// <returns><c>true</c>: both positions are in range; else <c>false</c></returns>
        public static bool IsInRangeNoZ(this Vector3 _pos1, Vector3 _pos2, float _distance)
        {
            if (
                FloatExtensions.ExtFloat.IsInRange(
                    _pos1.x,
                    _pos2.x,
                    _distance) &&
                    FloatExtensions.ExtFloat.IsInRange(
                        _pos1.y,
                        _pos2.y,
                        _distance)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
