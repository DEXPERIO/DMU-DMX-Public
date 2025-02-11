using System.ComponentModel;

namespace UnityEngine.XR.ARSubsystems
{
    /// <summary>
    /// Represents the segmentation stencil mode.
    /// </summary>
    public enum SegmentationStencilMode
    {
        /// <summary>
        /// The segmentation stencil is disabled and will not be generated.
        /// </summary>
        [Description("Disabled")]
        Disabled = 0,

        /// <summary>
        /// The segmentation stencil is enabled and will be generated at the fastest resolution.
        /// </summary>
        [Description("Fastest")]
        Fastest = 1,

        /// <summary>
        /// The segmentation stencil is enabled and will be generated at the medium resolution.
        /// </summary>
        [Description("Medium")]
        Medium = 2,

        /// <summary>
        /// The segmentation stencil is enabled and will be generated at the best resolution.
        /// </summary>
        [Description("Best")]
        Best = 3,
    }

    /// <summary>
    /// Extension for the <see cref="SegmentationStencilMode"/>.
    /// </summary>
    public static class SegmentationStencilModeExtension
    {
        /// <summary>
        /// Determine whether the segmentation stencil mode is enabled.
        /// </summary>
        /// <param name="segmentationStencilMode">The segmentation stencil mode to check.</param>
        /// <returns>
        /// <c>true</c> if the segmentation stencil mode is enabled. Otherwise, <c>false</c>.
        /// </returns>
        public static bool Enabled(this SegmentationStencilMode segmentationStencilMode)
            => segmentationStencilMode != SegmentationStencilMode.Disabled;
    }
}
