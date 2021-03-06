﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seer.AGVController
{
    public enum AGVErrorCodeTypes : int
    {
        成功 = 0,
        未知错误=1,

        请求不可用 = 40000,
        必要的请求参数缺失 = 40001,
        请求参数类型错误 = 40002,
        请求参数不合法 = 40003,
        运行模式错误 = 40004,
        非法的地图名 = 40005,
        正在烧写固件 = 40006,
        烧写固件错误 = 40007,
        文件名非法 = 40008,
        关机指令出现错误 = 40010,
        重启指令出现错误 = 40011,
        调度系统控制中 = 40012,
        robod错误 = 40013,
        robod警告 = 40014,
        正在手动充电不能运动 = 40015,
        地图解析出错 = 40050,
        地图不存在 = 40051,
        加载地图错误 = 40052,
        重载地图错误 = 40053,
        空地图 = 40054,
        文件不存在 = 40055,
        地图转换失败 = 40056,
        当前无可用rawmap文件 = 40057,
        当前无可用calib文件 = 40058,
        音频文件不存在 = 40060,
        播放音频出错 = 40061,
        上传音频文件失败 = 40062,
        音频正在播放中 = 40063,
        保存模型文件出错 = 40069,
        模型文件解析错误 = 40070,
        标定数据解析错误 = 40071,
        保存标定文件出错 = 40072,
        清除标定数据出错 = 40073,
        请求执行超时 = 40100,
        请求被禁止 = 40101,
        机器人繁忙 = 40102,
        内部错误 = 40199,
        解析任务链错误 = 40200,
        任务链名字非法 = 40201,
        任务链不存在 = 40202,
        任务链正在执行中 = 40203,
        设置参数类型错误 = 40300,
        设置的参数不存在 = 40301,
        设置参数出错 = 40302,
        设置并保存参数类型错误 = 40310,
        设置并保存参数不存在 = 40311,
        设置并保存出错 = 40312,
        重载的参数类型错误 = 40320,
        重载的参数不存在 = 40321,
        重载参数出错 = 40322,
        初始化状态错误 = 41000,
        地图载入状态错误 = 41001,
        重定位状态错误 = 41002,
        找不到重定位的robotHome = 41003,
        置信度过低 = 41004,
        找不到起点 = 41100,
        找不到准备点 = 41101,
        找不到终点 = 41102,
        充电点不存在 = 41103,
        速度值非法 = 41200,
        辊筒或皮带连接错误 = 42000,
        辊筒或皮带类型未知 = 42001,
        辊筒或皮带不支持该指令 = 42002,
        顶升机构连接错误 = 42003,
        顶升机构类型未知 = 42004,
        顶升机构不支持该指令 = 42005,
        升降操作出错 = 43000,


        //若用户将某类型的报文发错了端口将得到这个响应
        错误的报文类型 = 60000,
        //报文类型号未在上文中定义
        未知的报文类型 = 60001,
        //当数据区无法反序列化为 JSON 对象时将得到这个响应
        错误的数据区 = 60002,
        协议版本错误时得到的响应 = 60003,
        //，服务器会主动断连接，限制 200 MB
        数据区过大 = 60004,

    }
}
