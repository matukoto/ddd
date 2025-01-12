# 関数型ドメインモデリング

## 第1部　ドメインの理解

### 第1章 ドメイン駆動設計の紹介

#### 1.1 モデルを共有することの重要性

#### 1.2 ビジネスイベントによるドメインの理解

#### 1.3 ドメインをサブドメインに分割する

#### 1.4 境界づけられたコンテキストを利用した解決手段の作成

#### 1.5 ユビキタス言語の創造

#### 1.6 ドメイン駆動設計の概念の要約

#### 1.7 まとめ

### 第2章 ドメインの理解

#### 2.1 ドメインエキスパートへのインタビュー

#### 2.2 データベース駆動設計をしたいという衝動との戦い

#### 2.3 クラス駆動設計をしたいという衝動との戦い

#### 2.4 ドメインの文書化

#### 2.5 受注のワークフローを深堀りする

#### 2.6 複雑さをドメインモデルで表現する

#### 2.7 まとめ

### 第3章 関数型アーキテクチャ

#### 3.1 自律的なソフトウェアコンポーネントとしての境界づけられたコンテキスト

#### 3.2 境界づけられたコンテキストのコミュニケーション

#### 3.3 境界づけられたコンテキスト間の契約

#### 3.4 境界づけられたコンテキストでのワークフロー

#### 3.5 境界づけられたコンテキストの中のコード構造

#### 3.6 まとめ

#### 3.7 次にやること

## 第2部　ドメインのモデリング

### 第4章 型の理解

#### 4.1 関数の理解

#### 4.2 型と関数

#### 4.3 型の合成

#### 4.4 F#の型を扱う

#### 4.5 型の合成によるドメインモデルの構築

#### 4.6 省略可能な値、エラー、およびコレクションのモデリング

#### 4.7 ファイルやプロジェクトでの型の整理

#### 4.8 まとめ

### 第5章 型によるドメインモデリング

#### 5.1 ドメインモデルの見直し

#### 5.2 ドメインモデルのパターンを見る

#### 5.3 単純な値のモデリング

#### 5.4 複雑なデータのモデリング

#### 5.5 関数によるワークフローのモデリング

#### 5.6 アイデンティティの考察：値オブジェクト

#### 5.7 アイデンティティの考察：エンティティ

#### 5.8 集約

#### 5.9 すべてを組み合わせる

#### 5.10 まとめ

### 第6章 ドメインの完全性と整合性

#### 6.1 単純な値の完全性

#### 6.2 測定単位

#### 6.3 型システムによる不変条件の強制

#### 6.4 ビジネスルールを型システムで表現する

#### 6.5 整合性

#### 6.6 まとめ

### 第7章 パイプラインによるワークフローのモデリング

#### 7.1 ワークフローの入力

#### 7.2 状態の集合による注文のモデリング

#### 7.3 ステートマシン

#### 7.4 型を使ったワークフローの各ステップのモデリング

#### 7.5 エフェクトの文書化

#### 7.6 ステップからワークフローを合成する

#### 7.7 依存関係は設計の一部ですか？

#### 7.8 パイプラインの完成形

#### 7.9 長時間稼働するワークフロー

#### 7.10 まとめ

#### 7.11 次にやること

## 第3部　モデルの実装

### 第8章 関数の理解

#### 8.1 関数、関数、どこにでも

#### 8.2 「もの」としての関数

#### 8.3 全域関数

#### 8.4 関数合成

#### 8.5 まとめ

### 第9章 実装：パイプラインの合成

#### 9.1 単純型を扱う

#### 9.2 関数の型から実装を導く

#### 9.3 検証ステップの実装

#### 9.4 残りのステップの実装

#### 9.5 パイプラインのステップを1つに合成する

#### 9.6 依存関係の注入

#### 9.7 依存関係のテスト

#### 9.8 組み立てられたパイプライン

#### 9.9 まとめ

### 第10章 実装：エラーの扱い

#### 10.1 Result型を使ってエラーを明示する

#### 10.2 ドメインエラーを扱う

#### 10.3 Resultを生成する関数の連鎖

#### 10.4 パイプラインでのbindとmapの使用

#### 10.5 他の種類の関数を2トラックモデルに適合させる

#### 10.6 コンピュテーション式で暮らしを楽にする

#### 10.7 モナドなど

#### 10.8 非同期エフェクトの追加

#### 10.9 まとめ

### 第11章 シリアライズ

#### 11.1 永続化とシリアライズ

#### 11.2 シリアライズのための設計

#### 11.3 シリアライズコードとワークフローの連携

#### 11.4 シリアライズの全体例

#### 11.5 ドメイン型をDTOに変換する方法

#### 11.6 まとめ

### 第12章 永続化

#### 12.1 永続化を端に追いやる

#### 12.2 コマンドとクエリの分離

#### 12.3 境界づけられたコンテキストはデータストレージを所有しなければならない

#### 12.4 ドキュメントデータベースを扱う

#### 12.5 リレーショナルデータベースを扱う

#### 12.6 トランザクション

#### 12.7 まとめ

### 第13章 設計を進化させ、きれいに保つ

#### 13.1 変更点1：送料の追加

#### 13.2 変更点2：VIP顧客への対応の追加

#### 13.3 変更点3：プロモーションコードのサポートの追加

#### 13.4 変更点4：営業時間制約の追加

#### 13.5 さらなる要件変更への対応

#### 13.6 まとめ

#### 13.7 本書のまとめ

