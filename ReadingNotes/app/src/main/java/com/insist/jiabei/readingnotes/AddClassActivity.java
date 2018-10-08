package com.insist.jiabei.readingnotes;

import android.content.ContentValues;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class AddClassActivity extends AppCompatActivity {

    private EditText et;
    private Button b;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_class);

        et=(EditText)findViewById(R.id.className);
        b=(Button)findViewById(R.id.add);


        //添加按钮
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String className=et.getText().toString();
                ContentValues values=new ContentValues();
                //在values中添加内容
                values.put("className",className);
                //实例化数据库类
                DBHelper helper=new DBHelper(getApplicationContext());
                //插入数据
                helper.insert_class(values);
                //实例化Intent
                Intent intent=new Intent(AddClassActivity.this,BookClassActivity.class);
                //启动Intent
                Toast.makeText(AddClassActivity.this, "添加成功", Toast.LENGTH_SHORT).show();
                startActivity(intent);

            }

        });
    }
}
