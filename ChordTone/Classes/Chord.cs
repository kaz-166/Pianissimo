using System.ComponentModel;
using ChordTone.DTOs;
using ChordTone.Enums;

namespace ChordTone.Classes
{
    /// <summary>
    /// 和音クラス
    /// </summary>
    /// <remarks>
    /// コンストラクタ
    /// </remarks>
    /// <param name="instractor">コード生成指示</param>
    public class Chord(PitchDto instractor)
    {
        private Tone _key = instractor.Root;

        private Pitch _third = instractor.Third;

        private Pitch _fifth = instractor.Fifth;

        private Pitch _seventh = instractor.Seventh;

        private List<Tone> _tone = [];

        public List<Tone> CodeTones()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // ３度
            switch (_third)
            {
                case Pitch.Major: 
                    _tone.Add(_key.Get(4));
                    break;
                case Pitch.Minor: 
                    _tone.Add(_key.Get(3));
                    break;
;           }

            // ５度
            switch (_fifth)
            {
                case Pitch.Parfect: 
                    _tone.Add(_key.Get(7)); 
                    break;
                case Pitch.Diminished:
                    _tone.Add(_key.Get(6));
                    break;
            }

            // ７度
            switch (_seventh)
            {
                case Pitch.Major:
                    _tone.Add(_key.Get(11));
                    break;
                case Pitch.Minor:
                    _tone.Add(_key.Get(10));
                    break;
                case Pitch.Diminished:
                    _tone.Add(_key.Get(9));
                    break;
                case Pitch.Omit:
                    break;
            }

            return _tone;
        }

   
    }
}
