var data = new MyData { Id = 1, Name = "John" };
var response = await PostAsync<MyData>(data, CancellationToken.None);
