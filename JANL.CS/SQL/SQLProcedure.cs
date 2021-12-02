using System.Data;

namespace JANL.SQL
{   /// <summary>
	/// Процедура возвращающая <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T">Тип значения возвращаемого процедурой</typeparam>
	public abstract class SQLProcedure<T> : BaseSQLCommand<T>
	{
		/// <summary>
		/// Создаёт новую процедуру с именем вызывающего метода
		/// </summary>
		public SQLProcedure(string Name) : base(Name, CommandType.StoredProcedure) { }
	}
}