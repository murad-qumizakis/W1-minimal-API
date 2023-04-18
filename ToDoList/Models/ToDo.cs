using System;
using System.Text.Json;

namespace ToDoList.Models
{
	public class ToDo
	{
		public string? Id { get; set; }
		public string? name { get; set; }
		public string? createdAt { get; set; }
		public string? content{ get; set; }
		public override string ToString() => JsonSerializer.Serialize<ToDo>(this);

    }
}

