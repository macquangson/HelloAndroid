using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
	[Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		#region Khai báo biến, Mapping control giữa Layout và Code Behind
		Button btnHello;
		TextView txtName;
		EditText editTxtName;
		#endregion
		/// <summary>
		/// Map ID giữa control và Layout
		/// </summary>
		private void MapingControl()
		{
			btnHello = FindViewById<Button>(Resource.Id.btnHello);
			txtName = FindViewById<TextView>(Resource.Id.txtName);
			editTxtName = FindViewById<EditText>(Resource.Id.editTextName);
		}
		/// <summary>
		/// Đặt các sự kiện vào Control
		/// </summary>
		private void SetControlEvent()
		{
			btnHello.Click += BtnHello_Click;
		}
		/// <summary>
		/// Sự kiện OnCreate của Activiti
		/// </summary>
		/// <param name="bundle"></param>
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			MapingControl();
			SetControlEvent();

		}
		/// <summary>
		/// Sự kiện bấm nút Hello trên Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnHello_Click(object sender, System.EventArgs e)
		{
			Toast.MakeText(this, "Hello from " + editTxtName.Text, ToastLength.Long).Show();
		}
	}
}

