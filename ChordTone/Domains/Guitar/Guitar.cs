using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Guitar
{
    /// <summary>
    /// ギタークラス
    /// </summary>
    public class Guitar
    {
        /// <summary>
        /// 弦リストオブジェクト
        /// </summary>
        private List<String> Strings = new();

        /// <summary>
        /// ギタークラス コンストラクタ
        /// </summary>
        /// <param name="SixthTone">6弦開放音</param>
        /// <param name="FifthTone">5弦開放音</param>
        /// <param name="ForthTone">4弦開放音</param>
        /// <param name="ThirdTone">3弦開放音</param>
        /// <param name="SecoundTone">2弦開放音</param>
        /// <param name="FirstTone">1弦開放音</param>
        public Guitar(Tone SixthTone, Tone FifthTone, Tone ForthTone, Tone ThirdTone, Tone SecoundTone, Tone FirstTone)
        {
            Strings.Add(new String(FirstTone));
            Strings.Add(new String(SecoundTone));
            Strings.Add(new String(ThirdTone));
            Strings.Add(new String(ForthTone));
            Strings.Add(new String(FifthTone));
            Strings.Add(new String(SixthTone));
        }

        /// <summary>
        /// ギタークラス コンストラクタ
        /// </summary>
        /// <remarks>
        /// 初期のチューニングを指定しない場合はレギュラーチューニング(E-A-D-G-B-E)になります。
        /// </remarks>
        public Guitar()
        {
            Strings.Add(new String(Tone.E));
            Strings.Add(new String(Tone.B));
            Strings.Add(new String(Tone.G));
            Strings.Add(new String(Tone.D));
            Strings.Add(new String(Tone.A));
            Strings.Add(new String(Tone.E));
        }


        /// <summary>
        /// ピッキングした時の音程を返します。
        /// </summary>
        /// <param name="str">弦番号</param>
        /// <param name="flet">フレット数</param>
        /// <returns></returns>
        public Tone Pick(int str, int flet) => Strings[str].Pick(flet);

        }
    }


    /// <summary>
    /// 弦クラス
    /// </summary>
    /// <param name="openTone">開放弦音程</param>
    public class String(Tone openTone)
    {
        /// <summary>
        /// 開放弦の音程
        /// </summary>
        private Tone _openTone = openTone;

        /// <summary>
        /// ピッキングした時の音程を返します。
        /// </summary>
        /// <param name="flet">押弦フレット位置</param>
        /// <returns>音程</returns>
        public Tone Pick(int flet) => _openTone.Get(flet);

        /// <summary>
        /// チューニングを行い、開放弦の音程を決定します。
        /// </summary>
        /// <param name="openTone">開放弦の音程</param>
        public void Tuning(Tone openTone)
        {
            _openTone = openTone;
        }
    }
}
