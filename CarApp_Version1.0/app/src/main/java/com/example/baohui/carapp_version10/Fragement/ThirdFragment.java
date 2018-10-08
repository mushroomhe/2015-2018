package com.example.baohui.carapp_version10.Fragement;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.baohui.carapp_version10.R;
import com.example.baohui.carapp_version10.view.SixangleView;
import com.github.mikephil.charting.charts.LineChart;
import com.github.mikephil.charting.data.Entry;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

/**
 * Created by dm on 16-3-29.
 * 第一个页面
 */
public class ThirdFragment extends Fragment {
    //private TextView textView4;//心率
    //private TextView textView;//收缩压
    ///private TextView textView8;//舒张压
    //int xinLv=75;
    private LineChart lineChart;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.sixangle, container, false);

        SixangleView sixangleView =(SixangleView) view.findViewById(R.id.sixangleview);

        //分值给出的计算
        int count_xinlvpresent=100;
        int count_xinlvover=10;
        int xinlv_count=10*(count_xinlvpresent/(count_xinlvover+count_xinlvpresent));

        int count_xueyapresent=90;
        int cout_xueyaover=10;
        int xueya_count=10*(count_xueyapresent/(cout_xueyaover+count_xueyapresent));

        int sudu_present=90;
        int sudu_over=10;
        int sudu_count=10*(sudu_present/(sudu_over+sudu_present));

        String xinllv="8.5";
        String jiashixingwei="9.5";
        String pilao="10";
        String chesu="9";
        String shentijiankang="9";
        String xueya="8";

        sixangleView.setData("8.5","9.5","10","9","9","8");
        /**
       /// textView4=(TextView) view.findViewById(R.id.textView4);
        //String str=""+xinLv+"次/分钟";
        //textView4.setText(str);

        //textView=(TextView) view.findViewById(R.id.textView);
        //textView.setText("104mmhg");

        //textView8=(TextView) view.findViewById(R.id.textView8);
        //textView8.setText("86mmhg");

        lineChart=(LineChart) view.findViewById(R.id.lineChart);

        List<String> xDataList = new ArrayList<>();// x轴数据源
        List<Entry> yDataList = new ArrayList<>();// y轴数据数据源
        //给上面的X、Y轴数据源做假数据测试
        for (int i = 0; i < 14; i++) {
            // x轴显示的数据
            xDataList.add(i + ":00");
            //y轴生成float类型的随机数
            Random rand = new Random();
            int value2 = rand.nextInt(40)+80;

            yDataList.add(new Entry(value2, i));
        }

        //显示图表,参数（ 上下文，图表对象， X轴数据，Y轴数据，图表标题，曲线图例名称，坐标点击弹出提示框中数字单位）
        ChartUtil.showChart(this.getActivity(),lineChart, xDataList, yDataList, "心跳趋势图", "心跳次数/时间","次/分钟");
         */
        return view;
    }


}