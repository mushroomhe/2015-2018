package com.insist.jiabei.readingnotes;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Administrator on 2018/6/17.
 */

public class DBHelper extends SQLiteOpenHelper {

    //数据库名，表名
    private static final String DB_NAME="note.db";
    private static final String TBL_CLASS="bookClassTBL";
    private static final String TBL_BOOK="bookInfoTBL";
    private static final String TBL_USER="userTBL";
    private static final String TBL_NOTE="noteTBL";


    //private static final String TBL_NAME="stuTbl";

    //创建表的语句
    private static final String CREATE_TBL_CLASS="CREATE TABLE "+"bookClassTBL(_id INTEGER DEFAULT '1' NOT"+" NULL PRIMARY KEY AUTOINCREMENT,className TEXT)";
    private static final String CREATE_TBL_BOOK="CREATE TABLE "+"bookInfoTBL(_id INTEGER DEFAULT '1' NOT"+" NULL PRIMARY KEY AUTOINCREMENT,bookName TEXT,author TEXT,press TEXT,ISBN TEXT,className TEXT)";
    private static final String CREATE_TBL_USER="CREATE TABLE "+"userTBL(_id INTEGER DEFAULT '1' NOT"+" NULL PRIMARY KEY AUTOINCREMENT,username TEXT,password TEXT)";
    private static final String CREATE_TBL_NOTE="CREATE TABLE "+"noteTBL(_id TEXT NOT"+" NULL PRIMARY KEY,content TEXT,userId int,bookId int)";


    //private static final String CREATE_TBL="CREATE TABLE "+"stuTbl(_id INTEGER DEFAULT '1' NOT"+" NULL PRIMARY KEY AUTOINCREMENT,name TEXT,hobby TEXT)";
    //SQLiteDatabase实例
    private SQLiteDatabase db;
    private SQLiteDatabase db2;
    //构造方法
    public DBHelper(Context context)
    {
        super(context,DB_NAME,null,2);
        System.out.printf("创建数据库");
    }
    //创建表
    public void onCreate(SQLiteDatabase db)
    {
        this.db=db;
        db.execSQL(CREATE_TBL_CLASS);
        db.execSQL(CREATE_TBL_BOOK);
        db.execSQL(CREATE_TBL_USER);
        db.execSQL(CREATE_TBL_NOTE);
        System.out.printf("创建表");
    }
    //插入方法
    public void insert_user(ContentValues values)
    {
        //获得SQLiteDatabase实例
        SQLiteDatabase db=getWritableDatabase();
        //插入
        db.insert(TBL_USER,null,values);
        db.close();
        System.out.printf("数据库插入操作");
    }
    //插入方法
    public void insert_class(ContentValues values)
    {
        //获得SQLiteDatabase实例
        SQLiteDatabase db=getWritableDatabase();
        //插入
        db.insert(TBL_CLASS,null,values);
        db.close();
        System.out.printf("数据库插入操作");
    }
    //插入方法
    public void insert_book(ContentValues values)
    {
        //获得SQLiteDatabase实例
        SQLiteDatabase db=getWritableDatabase();
        //插入
        db.insert(TBL_BOOK,null,values);
        db.close();
        System.out.printf("数据库插入操作");
    }
    //插入方法
    public void insert_note(ContentValues values)
    {
        //获得SQLiteDatabase实例
        SQLiteDatabase db=getWritableDatabase();
        //插入
        db.insert(TBL_NOTE,null,values);
        db.close();
        System.out.printf("数据库插入操作");
    }
    //修改笔记

    public void update_note(ContentValues values)
    {
        SQLiteDatabase db=getWritableDatabase();
        String sql="update noteTBL set content='"+values.get("content")+"',userId='"+values.get("userId")+"',bookId='"+values.get("bookId")+"' where _id='"+values.get("_id")+"'";
        db.execSQL(sql);
    }
    //查询用户id
    public Cursor query_userId(String username)
    {
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        //Cursor c=db.rawQuery("select _id from userTBL where username="+"'"+username+"'",null);
        Cursor c=db.rawQuery("select * from userTBL where username=?",new String[]{username});
        return c;
    }
    //查询用户id
    public Cursor query_user_id(String username)
    {
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.rawQuery("select _id from userTBL where username="+"'"+username+"'",null);
        //Cursor c=db.rawQuery("select * from userTBL where username=?",new String[]{username});
        return c;
    }
    //查询书籍id
    public Cursor query_bookId(String bookName)
    {
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        //Cursor c=db.rawQuery("select * from bookInfoTBL where bookName="+"'"+bookName+"'",null);
        Cursor c=db.rawQuery("select * from bookInfoTBL where bookName=?",new String[]{bookName});
        return c;
    }

    //查询书籍id
    public String query_bookName(int id)
    {
        String bookName="";
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        //Cursor c=db.rawQuery("select * from bookInfoTBL where bookName="+"'"+bookName+"'",null);
        Cursor c=db.rawQuery("select bookName from bookInfoTBL where _id="+id,null);
        if(c.moveToFirst())
        {
            bookName=c.getString(0);
        }
        return bookName;
    }


    //查询方法
    public Cursor query_user()
    {
        System.out.printf("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.query(TBL_USER,null,null,null,null,null,null);
        return c;
    }
    //查询方法
    public Cursor query_bookClass()
    {
        System.out.printf("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.query(TBL_CLASS,null,null,null,null,null,null);
        return c;
    }
    //查询方法
    public Cursor query_book()
    {
        System.out.printf("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.query(TBL_BOOK,null,null,null,null,null,null);
        return c;
    }
    /*//查询方法
    public Cursor query_note(int userId)
    {
        System.out.print("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.rawQuery("select _id,bookId,content from noteTBL where userId="+userId,null);
        //Cursor c=db.query(TBL_NOTE,null,null,null,null,null,null);
        return c;
    }*/
    //查询一条笔记的详细内容
    public Cursor query_note_detail(int id)
    {
        String _id="";
        //获取一行
        //int a=id-1;
        //String sql="select * from noteTBL limit 1 offset "+a;

        SQLiteDatabase db2=getWritableDatabase();
        System.out.print("数据库查询方法");
        //查询获得Cursor
        //Cursor c=db.rawQuery(sql,null);
        Cursor c=db2.rawQuery("select * from noteTBL limit 1 offset "+id,null);
        if(c.moveToFirst())
        {
            _id=c.getString(c.getColumnIndex("_id"));
        }
        c.close();


        SQLiteDatabase db=getWritableDatabase();

        Cursor c2=db.rawQuery("select noteTBL._id,bookInfoTBL.bookName,noteTBL.content,noteTBL.bookId from noteTBL,bookInfoTBL where noteTBL.bookId=bookInfoTBL._id and noteTBL._id='"+_id+"'",null);
        return c2;
    }
    //查询方法
    public Cursor query_note(int userId)
    {
        System.out.print("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.rawQuery("select noteTBL._id,bookInfoTBL.bookName,noteTBL.content from noteTBL,bookInfoTBL where noteTBL.bookId=bookInfoTBL._id and userId="+userId,null);
        //Cursor c=db.query(TBL_NOTE,null,null,null,null,null,null);
        return c;
    }

    //查询所有的笔记
    public Cursor query_allNote()
    {
        System.out.print("数据库查询方法");
        //获得SQLiteDataBase实例
        SQLiteDatabase db=getWritableDatabase();
        //查询获得Cursor
        Cursor c=db.rawQuery("select noteTBL._id,userTBL.username,bookInfoTBL.bookName,noteTBL.content from noteTBL,bookInfoTBL,userTBL where noteTBL.bookId=bookInfoTBL._id and noteTBL.userId=userTBL._id",null);
        //Cursor c=db.query(TBL_NOTE,null,null,null,null,null,null);
        return c;
    }
    //删除方法（书的分类）
    public void del_class(int id)
    {
        System.out.printf("数据库删除方法");
        if(db==null)
        {
            //获得SQLiteDataBase实例
            SQLiteDatabase db=getWritableDatabase();
            //删除
            db.delete(TBL_CLASS,"_id=?",new String[]{String.valueOf(id)});
        }
    }
    //删除方法（书籍）
    public void del_book(int id)
    {
        System.out.printf("数据库删除方法");
        if(db==null)
        {
            //获得SQLiteDataBase实例
            SQLiteDatabase db=getWritableDatabase();
            //删除
            db.delete(TBL_BOOK,"_id=?",new String[]{String.valueOf(id)});
        }
    }
    //删除方法（用户）
    public void del_user(int id)
    {
        System.out.printf("数据库删除方法");
        if(db==null)
        {
            //获得SQLiteDataBase实例
            SQLiteDatabase db=getWritableDatabase();
            //删除
            db.delete(TBL_USER,"_id=?",new String[]{String.valueOf(id)});
        }
    }
    //删除方法（笔记）
    public void del_note(int id)
    {
        String _id="";
        //获取一行
        //int a=id-1;
        //String sql="select * from noteTBL limit 1 offset "+a;

        SQLiteDatabase db2=getWritableDatabase();
        System.out.print("数据库查询方法");
        //查询获得Cursor
        //Cursor c=db.rawQuery(sql,null);
        Cursor c=db2.rawQuery("select * from noteTBL limit 1 offset "+id,null);
        if(c.moveToFirst())
        {
            _id=c.getString(c.getColumnIndex("_id"));
        }
        c.close();


        System.out.printf("数据库删除方法");
        if(db==null)
        {
            //获得SQLiteDataBase实例
            SQLiteDatabase db=getWritableDatabase();
            //删除
            //db.execSQL("delete from noteTBL where _id='"+_id+"'");
            db.delete(TBL_NOTE,"_id=?",new String[]{_id});
        }
    }

    //关闭数据库
    public void close()
    {
        System.out.printf("数据库关闭");
        if(db!=null)
        {
            db.close();
        }
    }

    public void onUpgrade(SQLiteDatabase db,int oldVersion,int newVersion)
    {

    }
}
