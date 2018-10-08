package com.insist.jiabei.readingnotes;

import android.app.ListActivity;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.Toast;

public class FindUserNoteActivity extends ListActivity {

    private int userId;
    private String username;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_find_user_note);

        //Intent intent=new Intent();
        //username=intent.getStringExtra("username");
        username=UserNoteActivity.userName;

        //实例DBHelper
        final DBHelper helper = new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db = helper.getWritableDatabase();

        Cursor cc=helper.query_userId(username);
        if(cc.moveToFirst())
        {
            userId=cc.getInt(cc.getColumnIndex("_id"));
        }
        cc.close();

        Cursor c = helper.query_note(userId);
        //列表项数组noteTBL._id,bookInfoTBL.bookName,noteTBL.content
        //String[] from = {"_id", "bookId", "content"};
        String[] from = {"noteTBL._id", "bookInfoTBL.bookName", "noteTBL.content"};
        //列表项id
        int[] to = {R.id.date, R.id.bookId, R.id.content};
        //适配器
        SimpleCursorAdapter adapter = new SimpleCursorAdapter(this, R.layout.activity_find_user_note, c, from, to, 0);
        //列表视图
        ListView listView = getListView();
        //为列表添加适配器
        listView.setAdapter(adapter);
        //关闭数据库
        helper.close();
    }
}
