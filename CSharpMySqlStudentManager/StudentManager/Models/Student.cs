namespace StudentManager.Models;

/// <summary>
/// students 테이블의 한 행을 표현하는 모델입니다.
/// </summary>
public sealed class Student
{
    public int Id { get; set; }
    public string StudentNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
