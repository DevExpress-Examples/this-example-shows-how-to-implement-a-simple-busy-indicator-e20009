namespace DevExpress.Xpf.Toolkit {
    using System;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;
    public class BusyIndicator : Control {
        public BusyIndicator() {
            DefaultStyleKey = typeof(BusyIndicator);
        }
        public override void OnApplyTemplate() {
            base.OnApplyTemplate();
            Storyboard story = (Storyboard)GetTemplateChild("Storyboard");
            if (story != null) {
                story.Begin();
            }
        }
   }
}