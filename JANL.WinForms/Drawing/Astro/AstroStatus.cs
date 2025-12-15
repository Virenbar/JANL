namespace JANL.Drawing
{
    public enum AstroStatus
    {
        /// <summary>
        /// Off, unavailable, disabled
        /// </summary>
        Off,

        /// <summary>
        /// Standby, available, enabled
        /// </summary>
        Standby,

        /// <summary>
        /// Normal, on, ok, fine, go, satisfactory
        /// </summary>
        Normal,

        /// <summary>
        /// Caution, warning, unstable, unsatisfactory, watch
        /// </summary>
        Caution,

        /// <summary>
        /// Serious, distress, error, needs attention
        /// </summary>
        Serious,

        /// <summary>
        /// Critical, severe, alert, form error, emergency, urgent
        /// </summary>
        Critical
    }
}