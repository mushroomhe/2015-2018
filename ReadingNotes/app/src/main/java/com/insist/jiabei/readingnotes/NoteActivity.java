package com.insist.jiabei.readingnotes;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class NoteActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_note);
    }

    //点击添加按钮，跳转到添加笔记的界面
    protected void AddNote_Click(View view) {
        Intent intent = new Intent();
        intent.setClass(NoteActivity.this, AddNoteActivity.class);
        startActivity(intent);
    }

    //单击查看按钮，跳转到我的读书笔记列表中
    protected void MyNoteList_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(NoteActivity.this,MyNoteListActivity.class);
        startActivity(intent);
    }

    //点击每个用户的笔记数量，查看所有人的笔记
    protected void AllNote_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(NoteActivity.this,AllNoteListActivity.class);
        startActivity(intent);
    }

    //进行查询某个用户的所有笔记
    protected void UserNote_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(NoteActivity.this,UserNoteActivity.class);
        startActivity(intent);
    }

}
