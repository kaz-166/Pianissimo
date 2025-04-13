## Usage
コード名を入力すると対応するコードトーンを返すCUIプログラムです。
三和音、四和音に対応しています。  
テンションコードおよび分数コードは未対応となります。今後拡張予定です。    

This CUI program returns the corresponding chord tone when a chord name(chord symbol) is entered. Triad and 7th chord tones are supported.
Tension chords（ex. add9 (9) and more...) and fractional chords(slash chords, for example C/E) are not yet supported. Expansion chords are planned for the future.

現在の対応状況は下記となります。
| 和音名 | 区分 |対応状況 |
| ---- | ---- | ---- |
| 長三和音(〇) |Triad| 対応済 |
| 短三和音(〇ｍ) |Triad| 対応済 |
| 増三和音(〇aug) |Triad| 対応済 |
| Suspended 4th(〇sus4) |Triad| 対応済 |
| 長七和音(〇△7, 〇M7, 〇maj7) |Seventh| 対応済 |
| 短七和音(〇m7) |Seventh| 対応済 |
| 導七和音(〇m7b5, 〇m7-5) |Seventh| 対応済 |
| 長七短五和音(〇mM7) |Seventh| 対応済 |
| 減七和音(〇dim) |Seventh| 対応済み |
| Add 9th(〇add9) |Tension| 未対応 |
| 長九和音(〇7(9), 〇9) |Tension| 未対応 |
| 分数コード |Others| 未対応 |

![スクリーンショット 2024-10-26 031234](https://github.com/user-attachments/assets/52f50e0f-1f99-4b14-b573-2a264194b0d8)

## コードネームの構文規則について
 コードシンボルの生成規則は、バッカス＝ナウア記法に則ると下記のように表せます。  
   ```
コードネーム文字列を<ChordName>とすると、  
<ChordName> := <Root><Attributes>  
<Root> := C|D|E|F|G|A|B [#|b]  
<Attributes> := [m|m7|7|M7|mM7|Maj7|△7|aug|dim|m7-5|m7b5|sus4]
```

