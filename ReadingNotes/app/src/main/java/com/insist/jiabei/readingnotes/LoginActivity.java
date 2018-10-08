package com.insist.jiabei.readingnotes;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    private EditText etPhoneNumber;
    private EditText etPassword;
    public static String username;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

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

    //点击登录按钮，跳转到主界面
    protected void Home_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(LoginActivity.this,HomeActivity.class);

        etPhoneNumber=(EditText)findViewById(R.id.etPhoneNumber);
        etPassword=(EditText)findViewById(R.id.etPassword);

        if(etPhoneNumber.length()==0)
        {
            Toast.makeText(getApplicationContext(), "请输入手机号", Toast.LENGTH_SHORT).show();
        }
        else if(etPassword.length()==0)
        {
            Toast.makeText(getApplicationContext(), "请输入密码", Toast.LENGTH_SHORT).show();
        }
        else
        {
            String userName=etPhoneNumber.getText().toString();
            String passWord=etPassword.getText().toString();
            if (login(userName,passWord))
            {
                username=userName;
                //Intent intent1=new Intent(LoginActivity.this,AddNoteActivity.class);
                //intent1.putExtra("username",userName);
                //Intent intent2=new Intent(LoginActivity.this,MyNoteListActivity.class);
                //intent2.putExtra("username",userName);
                Toast.makeText(LoginActivity.this, "登录成功", Toast.LENGTH_SHORT).show();
                //startActivity(intent1);
                //startActivity(intent2);
                startActivity(intent);
            }
            else
            {
                Toast.makeText(LoginActivity.this, "登录失败", Toast.LENGTH_SHORT).show();
            }
        }

    }
    //验证登录
    public boolean login(String username,String password) {
        DBHelper dbHelper=new DBHelper(getApplicationContext());
        SQLiteDatabase db = dbHelper.getWritableDatabase();
        String sql = "select * from userTBL where username=? and password=?";
        Cursor cursor = db.rawQuery(sql, new String[] {username, password});
        if (cursor.moveToFirst()) {
            cursor.close();
            return true;
        }
        return false;
    }

}
