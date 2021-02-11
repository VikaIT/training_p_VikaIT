using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
	/// <summary>
	/// Протокол для разработки подсчета периметра прямоугольника
	/// </summary>
	interface IModel
	{
		/// <summary>
		/// Методб, возвращающий периметр прямоугольника по двум сторанам
		/// </summary>
		/// <param name="a">Одна сторна прямоугольника</param>
		/// <param name="b">Другая сторна прямоугольника</param>
		/// <returns></returns>
		int GetP(int a, int b);
	}
}
