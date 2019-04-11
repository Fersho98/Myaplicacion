package com.example.universitario.myapplication2;

import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.MediaController;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {
    VideoView miVideo;
    int oldCurrentPosition=-1;
    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.d("MainAct","onDestroy");
    }

    @Override
    protected void onPause() {
        super.onPause();
        oldCurrentPosition=miVideo.getCurrentPosition();
        Log.d("MainAct","Tiempo: "+ miVideo.getCurrentPosition());
    }

    @Override
    protected void onRestart() {
        super.onRestart();
        Log.d("MainAct","onRestart");
    }

    @Override
    protected void onStop() {
        super.onStop();
        Log.d("MainAct","onStop");
    }

    @Override
    protected void onStart() {
        super.onStart();
        Log.d("MainAct","onStart");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.d("MainAct","onResume");
        if (oldCurrentPosition!=-1){
            miVideo.seekTo(oldCurrentPosition);
            miVideo.start();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        miVideo =  findViewById(R.id.videoView);
        String vid= "android.resource://"+getPackageName()+"/"+R.raw.video;
        miVideo.setVideoURI(Uri.parse(vid));
        miVideo.setMediaController(new MediaController(this));
        miVideo.start();
//        <!--
//        MediaController mediaController =new MediaController( this);
//        VideoView.setMediaController(mediaController);
//        mediaController.setAnchorView(VideoView);
//        -->
        System.out.println("oncreate()");
        Log.d("MainAct","oncreate()");
        Button plays= findViewById(R.id.play);
        plays.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                miVideo.start();
            }
        });
        Button pauses=findViewById(R.id.pause);
        pauses.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                miVideo.pause();
            }
        });


         System.out.println("onCreate()");
         Log.d("MainAct","onCreate()");
    }


}
