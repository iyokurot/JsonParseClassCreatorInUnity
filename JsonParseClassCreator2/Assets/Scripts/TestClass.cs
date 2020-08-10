using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestClass {
/// <summary>
/// テスト文字列
/// </summary>
[SerializeField, HideInInspector]
private string test_str = default;
public string TestStr => test_str;

/// <summary>
/// テスト整数値
/// </summary>
[SerializeField, HideInInspector]
private int test_int = default;
public int TestInt => test_int;

}
