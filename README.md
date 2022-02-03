# net-upgrade-assistant-tutorial  
  
[2022/2/3 Microsoft Developer Day](https://msevents.microsoft.com/event?id=1619975101)  
16:45 – 17:25　ブレイクアウトセッション BS15  
「.NET アップグレード アシスタントで簡単にできます！ .NET Framework アプリの .NET 6 へのマイグレーション」  
で使用したサンプルコードです。  
  
本セッションでは、アプリを最新の環境に移行する場合に、事前に必要な作業量やコストや時間をできるだけ手間をかけずに見積もり、移行プロジェクトのGOサインをもらう目的で「作業計画」を作成するために
- ツールでどのようなことができるか  
- どのような手順でツールを使うと効果的か  
- ツールの調査結果をどう読み取るか  

についてご説明しています。
  
このサンプルコードは以下の2点を確認するための補足資料です  
- 移行前と移行後のソースコードは具体的にどこが違うか  
- ツールで移行しきれなかったコードはどの部分であり、それはどのように修正するのか  
  
# セッション資料・動画  
公式より公開されましたらリンクを追加します  
  
# 使用ツール  
## .NET Portability Analyzer  
https://marketplace.visualstudio.com/items?itemName=ConnieYau.NETPortabilityAnalyzer  
  
- ターゲットとする移行先のプラットフォームで使用できない（ビルドが通らず代替が必要な） API やコントロールを自動で数分で抽出してくれるツールです  
- ツールを使用することで、移行前の段階で移行後に手作業での修正が必要になるであろう箇所を洗い出すことができるため、移行作業のボリュームを確認するのに役立ちます。
  
## .NET アップグレード アシスタント  
[https://docs.microsoft.com/ja-jp/dotnet/core/porting/upgrade-assistant-overview](https://docs.microsoft.com/ja-jp/dotnet/core/porting/upgrade-assistant-overview?WT.mc_id=DT-MVP-5002467)  
  
- syntax や名前空間の問題でビルドが通らないコードを .NET 6 の新しい構文に変換するツールです。
- ツールで変換後のプロジェクトはすでに定型的なコードの変更が完了しているため、手作業での修正が必要な部分のみがビルドエラーや警告が残るため、移行作業のボリュームを確認するのに役立ちます。
  
# フォルダ構成  
```
net-upgrade-assistant-tutorial---+---01_NetFramework // 移行前の .NET Framework アプリ  
                                 |   +---AspNetAppNetFramework  
                                 |   +---WinFormsAppNetFramework  
                                 |  
                                 +---02_Net6Migrated // 移行後の .NET 6 アプリ  
                                     +---AspNetAppNet6  
                                     +---WinFormsAppNet6  
```
  
# .NET アップグレード アシスタントによるソースコード変換における留意点  
## ASP.NET MVC に関する留意点  
  
・移行前に、.NET Portability Analyzer で、移行後でサポートされていないコントロール API を確認する。   
・移行前と、移行後の csproj ファイルの記述の違いを確認する  
・スタートプロセスの違い（Global.asax、App_Startフォルダ）を確認する。  
・JS, css のレンダリング、静的リンクの違いを確認する  
・Microsoft.DotNet.UpgradeAssistant.Extensions.Default.Analyzers による指摘事項を確認する  
  
## WinForms に関する留意点  
・移行前の .NET Framework の時点で View と バックエンドを Binding するなど分離する（自動テスト導入のため）  
・移行前に .NET Portability Analyzer で、移行後でサポートされていないコントロール API を確認する。  
・移行前と、移行後の csproj ファイルの記述の違いを確認する  
・Microsoft.DotNet.UpgradeAssistant.Extensions.Default.Analyzers による指摘事項を確認する  
