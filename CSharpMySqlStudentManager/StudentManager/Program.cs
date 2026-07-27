using StudentManager.Data;
using StudentManager.Forms;

namespace StudentManager;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            string connectionString = MySqlDatabase.LoadConnectionString();
            var repository = new StudentRepository(connectionString);
            Application.Run(new MainForm(repository));
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"프로그램을 시작할 수 없습니다.\n\n{ex.Message}",
                "시작 오류",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
