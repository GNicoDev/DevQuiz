﻿using DevQuiz.Libraries.Core.Models;

namespace DevQuiz.TelegramBot.Models.InputModels
{
    /// <summary>
    /// Input model for update question
    /// </summary>
    public class UpdateQuestionInputModel : CreateQuestionInputModel, IHasKey<int>
    {
        /// <inheritdoc cref="IHasKey{TKey}.Id"/>
        public int Id { get; set; }
    }
}
