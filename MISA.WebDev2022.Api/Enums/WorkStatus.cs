namespace MISA.WebDev2022.Api.Enums
{
    /// <summary>
    /// Tình trạng công việc
    /// </summary>
    public enum WorkStatus
    {
        /// <summary>
        /// Chưa làm việc
        /// </summary>
        NotWork = 0,

        /// <summary>
        /// Đang làm việc
        /// </summary>
        CurrentlyWorking = 1,

        /// <summary>
        /// Ngừng làm việc
        /// </summary>
        StopWork = 2,

        /// <summary>
        /// Đã nghỉ việc
        /// </summary>
        Retired = 3
    }
}
