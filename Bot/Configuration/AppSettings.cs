namespace VoiceTexterBot.Configuration
{
    public class AppSettings
    {
        /// Токен Telegram API
        public string BotToken { get; set; }

        /// Папка загрузки аудио файлов
        public string DownloadsFolder { get; set; }

        /// Имя файла при загрузке
        public string AudioFileName { get; set; }

        /// Формат аудио при загрузке
        public string InputAudioFormat { get; set; }

        /// Формат аудио при загрузке
        public string OutputAudioFormat { get; set; }

        /// Битрейт аудио при загрузке
        public float InputAudioBitrate { get; set; }
    }
}