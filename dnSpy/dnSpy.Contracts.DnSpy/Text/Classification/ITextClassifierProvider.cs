﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.VisualStudio.Utilities;

namespace dnSpy.Contracts.Text.Classification {
	/// <summary>
	/// Creates <see cref="ITextClassifier"/>s. Export the instance with
	/// at least one <see cref="ContentTypeAttribute"/>.
	/// </summary>
	public interface ITextClassifierProvider {
		/// <summary>
		/// Creates a <see cref="ITextClassifier"/> or returns null
		/// </summary>
		/// <param name="contentType">Content type</param>
		/// <returns></returns>
		ITextClassifier Create(IContentType contentType);
	}
}
