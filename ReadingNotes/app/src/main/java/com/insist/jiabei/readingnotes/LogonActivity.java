package com.insist.jiabei.readingnotes;

import android.content.ContentValues;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class LogonActivity extends AppCompatActivity {
    private EditText etPhoneNumber;
    private EditText etPassword;
    private EditText etPassword2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_logon);

        android.support.v7.app.ActionBar actionBar = getSupportActionBar();
        if(actionBar != null){
            actionBar.setHomeButtonEnabled(true);
            actionBar.setDisplayHomeAsUpEnabled(true);
        }
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case android.R.id.home:
                this.finish(); // back button
                return true;
        }
        return super.onOptionsItemSelected(item);
    }

    //点击注册按钮，跳转到登录界面
    protected void Logon_Click(View view)
    {
        //实例化Intent
        Intent intent=new Intent();
        intent.setClass(LogonActivity.this,MainActivity.class);

        etPhoneNumber=(EditText)findViewById(R.id.etPhoneNumber);
        etPassword=(EditText)findViewById(R.id.etPassword);
        etPassword2=(EditText)findViewById(R.id.etPassword2);

        if(etPhoneNumber.length()==0)
        {
            Toast.makeText(getApplicationContext(), "请输入手机号", Toast.LENGTH_SHORT).show();
        }
        else if(etPassword.length()==0)
        {
            Toast.makeText(getApplicationContext(), "请输入密码", Toast.LENGTH_SHORT).show();
        }
        else if(!((etPassword2.getText().toString()).equals(etPassword.getText().toString())))
        {
            Toast.makeText(getApplicationContext(), "确认密码应与密码保持一致", Toast.LENGTH_SHORT).show();
        }
        else
        {
            String username=etPhoneNumber.getText().toString();
            String password=etPassword.getText().toString();
            ContentValues values=new ContentValues();
            //在values中添加内容
            values.put("username",username);
            values.put("password",password);
            //实例化数据库类
            DBHelper helper=new DBHelper(getApplicationContext());
            //插入数据
            helper.insert_user(values);
            //启动Intent
            startActivity(intent);
        }




    }
}
