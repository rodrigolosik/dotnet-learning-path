internal class Program
{
    private delegate void OnSuccessDelegate(IEnumerable<ArticleModel> data);
    private delegate void OnErrorDelegate(ErrorModel data);

    private static void Main(string[] args)
    {
        OnSuccessDelegate onSuccessHandler = OnSuccess;
        OnErrorDelegate onErrorHandler = OnError;
        GetArticle(onSuccessHandler, onErrorHandler);
    }

    private static void GetArticle(OnSuccessDelegate onSuccess, OnErrorDelegate onError)
    {
        try
        {
            var data = new List<ArticleModel>
            {
                new ArticleModel(1, "Orientação a objetos"),
                new ArticleModel(2, "Fundamentos do C#")
            };

            //throw new Exception("Deu ruim");
            onSuccess(data);
        }
        catch (Exception ex)
        {
            onError(new ErrorModel($"Ocorreu um erro: {ex.Message}"));
        }
    }

    private static void OnSuccess(IEnumerable<ArticleModel> data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item.Title);
        }
    }

    private static void OnError(ErrorModel data)
    {
        Console.WriteLine($"ERRO: {data.Message}");
    }
}

internal class ErrorModel
{
    public string Message { get; set; }

    public ErrorModel(string message)
    {
        Message = message;
    }
}

internal class ArticleModel
{
    public ArticleModel(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public int Id { get; set; }
    public string Title { get; set; }
}