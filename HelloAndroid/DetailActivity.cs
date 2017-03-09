using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloAndroid.Resources.layout
{
	[Activity(Label = "DetailActivity")]
	public class DetailActivity : Activity
	{
		#region Khai báo biến, Mapping control giữa Layout và Code Behind
		TextView txtPassingData;
		#endregion
		/// <summary>
		/// Map ID giữa control và Layout
		/// </summary>
		private void MapingControl()
		{
			txtPassingData = FindViewById<TextView>(Resource.Id.txtPassingData);
		}
		/// <summary>
		/// Đặt các sự kiện vào Control
		/// </summary>
		private void SetControlEvent()
		{

		}


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Detail);
			MapingControl();
			SetControlEvent();
			string b_passingData = Intent.GetStringExtra("MyData") ?? "Data not available";
			txtPassingData.Text = b_passingData;
		}
	}
}