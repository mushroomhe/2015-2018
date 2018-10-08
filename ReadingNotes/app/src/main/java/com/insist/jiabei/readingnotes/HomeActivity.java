package com.insist.jiabei.readingnotes;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

public class HomeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
    }

    //书籍分类管理
    protected void BookClass_Click(View view)
    {
        //实例化Intent
        Intent intent=new Intent(HomeActivity.this,BookClassActivity.class);
        startActivity(intent);
    }

    //书籍管理
    protected void Book_Click(View view)
    {
        //实例化Intent
        Intent intent=new Intent(HomeActivity.this,BookActivity.class);
        startActivity(intent);
    }

    //读书笔记
    protected void Note_Click(View view)
    {
        //实例化Intent
        Intent intent=new Intent(HomeActivity.this,NoteActivity.class);
        startActivity(intent);
    }


}
