package com.insist.jiabei.readingnotes;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class BookActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book);
    }

    //点击添加按钮，跳转到添加书籍的界面
    protected void AddBook_Click(View view) {
        Intent intent = new Intent();
        intent.setClass(BookActivity.this, AddBookActivity.class);
        startActivity(intent);
    }

    //点击查看按钮，查看此时已添加的书籍的界面
    protected void ListBook_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(BookActivity.this,BookListActivity.class);
        startActivity(intent);
    }


}
