## Usage
コード名を入力すると対応するコードトーンを返すCUIプログラムです。
三和音、四和音に対応しています。  
テンションコードは未対応となります。  
また、分数コードも未対応となります。  
![スクリーンショット 2024-10-26 031234](https://github.com/user-attachments/assets/52f50e0f-1f99-4b14-b573-2a264194b0d8)

## コードネームの構文規則について
 コードの生成規則は、バッカス＝ナウア記法に則ると下記のように表せる。  
   ```
コードネーム文字列を<ChordName>とすると、  
<ChordName> := <Root><Attributes>  
<Root> := C|D|E|F|G|A|B [#|b]  
<Attributes> := [m|m7|7|M7|mM7|Maj7|△7|aug|dim|m7-5|m7b5|sus4]
```

