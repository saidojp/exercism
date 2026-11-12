# バードウォッチャー

ExercismのC#トラックのバードウォッチャーへようこそ。
テストの実行やコードの提出について助けが必要な場合は、`HELP.md`を確認してください。
演習で行き詰まったら、`HINTS.md`を確認してください。でも、まずはそれを使わずに解いてみましょう :)

## Introduction

## 配列

C#では、0個以上の要素を保持できるデータ構造を_コレクション_と呼びます。**配列**は、固定のサイズ（長さ）を持ち、その要素がすべて同じ型でなければならないコレクションです。要素は、インデックスを使って配列に代入したり、配列から取り出したりできます。C#の配列は0から始まるため、最初の要素のインデックスは常に0です。

```csharp
// Declare array with explicit size (size is 2)
int[] twoInts = new int[2];

// Assign second element by index
twoInts[1] = 8;

// Retrieve the second element by index
twoInts[1] == 8; // => true
```

配列は、作成と値の設定を同時に行える短縮記法でも定義できます。この場合、コンパイラーが配列の要素数を判断できるため、長さは省略できます。

```csharp
// Three equivalent ways to declare and initialize an array (size is 3)
int[] threeIntsV1 = new int[] { 4, 9, 7 };
int[] threeIntsV2 = new[] { 4, 9, 7 };
int[] threeIntsV3 = { 4, 9, 7 };
```

配列は、配列インスタンスのメソッドやプロパティを呼び出すか、`Array`クラスで定義されている静的メソッドを使うことで操作できます。

## `for`ループ

`for`ループを使うと、条件が満たされるまでコードを繰り返し実行できます。

```csharp
for (int i = 0; i < 5; i++)
{
    System.Console.Write(i);
}

// => 01234
```

`for`ループは、4つの部分から構成されます。

1. 初期化子: ループに入る前に一度だけ実行されます。通常は、ループ内で使う変数を定義するために使います。
2. 条件: 各繰り返しの前に実行されます。これが`true`と評価される間、ループは実行され続けます。
3. 反復子: 各繰り返しの後に実行されます。通常は、ループ変数を変更する（多くの場合、増減させる）ために使います。
4. 本体: 各繰り返しで実行されるコードです。

## `foreach`ループ

配列もまた_コレクション_であるということは、インデックスで値にアクセスする以外に、`foreach`ループを使って_すべての_値を順に取り出せるということです。

```csharp
char[] vowels = new [] { 'a', 'e', 'i', 'o', 'u' };

foreach (char vowel in vowels)
{
    // Output the vowel
    System.Console.Write(vowel);
}

// => aeiou
```

## Instructions

この7日間に何羽の鳥が庭にやって来たかを記録している、熱心なバードウォッチャーです。

タスクは6つあり、どれも庭にやって来た鳥の数に関するものです。

## 1. 先週の記録を確認する

比較のために、先週の記録をいつも手元に残しています。先週の記録は、0、2、5、3、7、8、4でした。先週の記録を返す（_静的_）`BirdCount.LastWeek()`メソッドを実装しましょう。

```csharp
BirdCount.LastWeek();
// => [0, 2, 5, 3, 7, 8, 4]
```

## 2. 今日やって来た鳥の数を確認する

今日庭にやって来た鳥の数を返す`BirdCount.Today()`メソッドを実装しましょう。鳥の数は日付の順に並んでいて、最初の要素が最も古い日の数、最後の要素が今日の数です。

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.Today();
// => 1
```

## 3. 今日の数を1増やす

今日の数を1増やす`BirdCount.IncrementTodaysCount()`メソッドを実装しましょう。

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.IncrementTodaysCount();
birdCount.Today();
// => 2
```

## 4. 鳥が1羽も来なかった日があるか調べる

庭に鳥が1羽も来なかった日があれば`true`を返し、そうでなければ`false`を返す`BirdCount.HasDayWithoutBirds()`メソッドを実装しましょう。

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.HasDayWithoutBirds();
// => true
```

## 5. 最初の指定日数分について、やって来た鳥の数を計算する

週の初めから庭にやって来た鳥の数を返す`BirdCount.CountForFirstDays()`メソッドを実装しましょう。ただし、数えるのは週の初めから指定された日数分に限ります。

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.CountForFirstDays(4);
// => 14
```

## 6. 忙しい日の数を計算する

日によって、にぎやかな日もあれば静かな日もあります。忙しい日とは、庭に5羽以上の鳥がやって来た日のことです。
忙しい日の数を返す`BirdCount.BusyDays()`メソッドを実装しましょう。

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.BusyDays();
// => 2
```

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @yzAlvin