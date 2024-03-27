namespace SampleBlazorApp.Data;

public class MydataService
{
    private List<Mydata> datos = new()
    {
        new Mydata("Taro", "hoge", "taro@yamada"),
        new Mydata("Hanako", "foo", "hanako@flower"),
        new Mydata("Sachiko", "bar", "sachiko@happy")
    };

    public Task<Mydata> GetMydataAsync(int n)
    {
        int num = n < 0 ? 0 : n > datos.Count ? datos.Count : n;
        return Task.FromResult(datos[n]);
    }
}
