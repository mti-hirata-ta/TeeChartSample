using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace TeeChartSample
{


	[Activity (Label = "TeeChartSample", MainLauncher = true)]
	public class Activity1 : Activity
	{
		WebView webView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			webView = FindViewById<WebView> (Resource.Id.webView);
			SettingWebView ();
		}

		private void SettingWebView(){
			// JavaScriptを使えるようにする
			webView.Settings.JavaScriptEnabled = true;
			webView.LoadUrl ("file:///android_asset/html/TeeChartGraph.html");
//			GraphData graphData = new GraphData (this);
//			webView.AddJavascriptInterface (graphData, "graphData");
		}


		public class GraphData : Java.Lang.Object{

			public void TestMethod(){
			}
		}

	}
}