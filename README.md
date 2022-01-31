# net-upgrade-assistant-tutorial
　
2022/2/3 Microsoft Developer Day 
16:45 – 17:25　ブレイクアウトセッション BS15
「.NET アップグレード アシスタントで簡単にできます！ .NET Framework アプリの .NET 6 へのマイグレーション」
で使用したサンプルコードです。
　
# セッション資料・動画
リンク準備中
　
# フォルダ構成
net-upgrade-assistant-tutorial---+---01_NetFramework // 移行前の .NET Framework アプリ
                                 |   +---AspNetAppNetFramewor
                                 |   +---WinFormsAppNetFramework
                                 |
                                 +---02_Net6Migrated // 移行後の .NET 6 アプリ
                                     +---AspNetAppNet6
                                     +---WinFormsAppNet6

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


