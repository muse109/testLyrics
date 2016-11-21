using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace testLyrics
{
    [Activity(Label = "testLyrics", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var iF = new IntentFilter();
            iF.AddAction("com.android.music.metachanged");
            iF.AddAction("com.android.music.playstatechanged");
            iF.AddAction("com.android.music.playbackcomplete");
            iF.AddAction("com.android.music.queuechanged");
            iF.AddAction("com.htc.music.metachanged");
            iF.AddAction("fm.last.android.metachanged");
            iF.AddAction("com.sec.android.app.music.metachanged");
            iF.AddAction("com.nullsoft.winamp.metachanged");
            iF.AddAction("com.amazon.mp3.metachanged");
            iF.AddAction("com.miui.player.metachanged");
            iF.AddAction("com.real.IMP.metachanged");
            iF.AddAction("com.sonyericsson.music.metachanged");
            iF.AddAction("com.rdio.android.metachanged");
            iF.AddAction("com.samsung.sec.android.MusicPlayer.metachanged");
            iF.AddAction("com.tbig.playerpro.metachanged");           
            iF.AddAction("com.andrew.apollo.metachanged");
          

            mReceiver lbr = new mReceiver();
           RegisterReceiver(lbr, iF);


        }

        [BroadcastReceiver]
        public class mReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {
                //String action = intent.Getac();
                string cmd = intent.GetStringExtra("command");
               // Log.v("tag ", action + " / " + cmd);
                string artist = intent.GetStringExtra("artist");
                string album = intent.GetStringExtra("album");
                string track = intent.GetStringExtra("track");
                //Log.v("tag", artist + ":" + album + ":" + track);
                Toast.MakeText(context, track, ToastLength.Long).Show();
            }
        }





    };
}



