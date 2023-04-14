using System;
using System.Data;

/// <summary>
/// Ví dụ GIAN LẬN tuổi trong bóng đá
/// </summary>
public class FootballPlayer
{
    #region Fields

    /// <summary>
    /// Tên cầu thủ
    /// </summary>
    private string _name;

    /// <summary>
    /// Tuổi thật của cầu thủ
    /// </summary>
    private int _realAge;

    #endregion


    #region Properties

    /// <summary>
    /// Tên cầu thủ
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Tuổi gian lận của cầu thủ
    /// </summary>
    public int Age
    {
        // GIAN LẬN 2 tuổi
        get => _realAge - 2;
        set => _realAge = value;
    }

    /// <summary>
    /// Tuổi của cầu thủ viết dạng chữ
    /// </summary>
    public string AgeInString
    {
        get
        {
            return string.Format($"{0} years old", Age);
        }
    }

    #endregion
}

namespace EncapsulationExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = new FootballPlayer();
            Console.WriteLine(name._name); // => Lỗi
        }
    }
}
