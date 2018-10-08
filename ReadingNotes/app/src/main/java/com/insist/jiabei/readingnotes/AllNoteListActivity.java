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

public class AllNoteListActivity extends ListActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_all_note_list);

        //实例DBHelper
        final DBHelper helper = new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db = helper.getWritableDatabase();

        Cursor c = helper.query_allNote();
        //列表项数组noteTBL._id,bookInfoTBL.bookName,noteTBL.content
        //String[] from = {"_id", "bookId", "content"};
        String[] from = {"noteTBL._id","userTBL.username", "bookInfoTBL.bookName", "noteTBL.content"};
        //列表项id
        int[] to = {R.id.date,R.id.userId, R.id.bookId, R.id.content};
        //适配器
        SimpleCursorAdapter adapter = new SimpleCursorAdapter(this, R.layout.activity_all_note_list, c, from, to, 0);
        //列表视图
        ListView listView = getListView();
        //为列表添加适配器
        listView.setAdapter(adapter);
        //对话框
        final AlertDialog.Builder builder = new AlertDialog.Builder(this);
        /*
        //为listview添加监听

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                final long temp = i;
                builder.setMessage("您想对此条笔记进行什么操作？").setNegativeButton("删除", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        builder.setMessage("是否删除此条读书笔记？").setNegativeButton("是",new DialogInterface.OnClickListener()
                        {
                            @Override
                            public void onClick(DialogInterface dialogInterface, int i) {
                                //删除数据
                                helper.del_note((int)temp);
                                //提示删除成功
                                Toast.makeText(MyNoteListActivity.this, "删除成功", Toast.LENGTH_SHORT).show();
                                //查询
                                Cursor c=helper.query_note(user_id);
                                String[] from = {"noteTBL._id", "bookInfoTBL.bookName", "noteTBL.content"};
                                int[] to = {R.id.date, R.id.bookId, R.id.content};
                                SimpleCursorAdapter adapter=new SimpleCursorAdapter(getApplicationContext(),R.layout.activity_my_note_list,c,from,to,0);
                                ListView listView=getListView();
                                listView.setAdapter(adapter);
                            }
                        }).setPositiveButton("否",new DialogInterface.OnClickListener()
                        {
                            public void onClick(DialogInterface dialog,int which){
                            }
                        });
                        //创建提示对话框
                        AlertDialog ad=builder.create();
                        //显示对话框
                        ad.show();
                    }
                }).setPositiveButton("编辑", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        Intent intent=new Intent();
                        intent.setClass(MyNoteListActivity.this,EditNoteActivity.class);
                        intent.putExtra("extra_data",temp);
                        startActivity(intent);
                    }
                }).setNeutralButton("取消", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {

                    }
                });
                //创建提示对话框
                AlertDialog ad = builder.create();
                //显示对话框
                ad.show();
            }
        });*/
        //关闭数据库
        helper.close();
    }
}
