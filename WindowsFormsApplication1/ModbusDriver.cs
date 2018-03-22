using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modbus.Device;
using System.Net.Sockets;
using System.Threading;
namespace WindowsFormsApplication1
{
    /* 可封装调用Modus.dll内部方法，也可直接调用Modus.dll内部方法 
     * 建议封装内部方法后再调用封装后的类方法：a.避免主程序代码冗长; b.封装业务逻辑的通讯程序
     * 
     * 调用Modbus.dll内部方法步骤：
     * 1.在工程文件中添加dll引用（FtdAdapter.dll、log4net.dll、Modbus.dll、Unme.Common.dll）
     * 2.在程序中添加Modbus.Device命名空间
     * 3.添加通讯类
     * 4.初始化通讯类
     * 5.设置通讯类的通讯参数
     * 6.根据实际需求调用通讯类的方法，读取Modbus相关区域数据
     * HXT 2018.3.14 由CTOP工程助手删减而来
     */
    public class ModbusDriver
    {
        /* 1.定义通讯类 */
        private ModbusIpMaster master;

        /* 2.初始化master通讯对象为ModbusTCP */
        public string Init(string ipAddress, int port)
        {
            try
            {
                TcpClient client = new TcpClientWithTimeout(ipAddress, port, 1000).Connect();
                master = ModbusIpMaster.CreateIp(client);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "NO_ERR";

        }

        /* 3.设置master通讯对象的相关通讯参数，该参数可修改 */
        public string SetParam(int readTimeout = 2000,
                            int retries = 3,
                            int WaitToRetryMilliseconds = 1000,
                            int WriteTimeout = 2000)
        {
            if (master == default(ModbusIpMaster))
            {
                return "UnInit modbus master driver";
            }
            master.Transport.ReadTimeout = readTimeout;
            master.Transport.Retries = retries;
            master.Transport.WaitToRetryMilliseconds = WaitToRetryMilliseconds;
            master.Transport.WriteTimeout = WriteTimeout;
            return "NO_ERR";
        }

        /* 4.调用master通讯对象的相关通讯方法 即可读取Modbus相关区域数据 
         * 
         * 备注：这里不再列出写modbus数据的方法，原理和下面四个函数一样，只是调用的Modbus.dll内部方法函数不一样
         */

        /* 读多个线圈（DO） */
        public void ReadCoils(ushort startAddress, ushort numberOfPoints, ref List<bool> list)
        {
            bool[] data;
            data = master.ReadCoils(startAddress, numberOfPoints);
            list = data.ToList();
        }

        /* 读多个保持寄存器（AO） */
        public void ReadHoldingRegisters(ushort startAddress, ushort numberOfPoints, ref List<ushort> list)
        {
            ushort[] data;
            data = master.ReadHoldingRegisters(startAddress, numberOfPoints);
            list = data.ToList();
        }

        /* 读多个输入寄存器（AI）*/
        public void ReadInputRegisters(ushort startAddress, ushort numberOfPoints, ref List<ushort> list)
        {
            ushort[] data;
            data = master.ReadInputRegisters(startAddress, numberOfPoints);
            list = data.ToList();
        }

        /* 读多个触点（DI） */
        public void ReadInputs(ushort startAddress, ushort numberOfPoints, ref List<bool> list)
        {
            bool[] data;
            data = master.ReadInputs(startAddress, numberOfPoints);
            list = data.ToList();
        }
    }

    /* 定义可控制回复超时时间的TCP连接类 */
    public class TcpClientWithTimeout
    {
        protected string _hostname;
        protected int _port;
        protected int _timeout_milliseconds;
        protected TcpClient connection;
        protected bool connected;
        protected Exception exception;

        public TcpClientWithTimeout(string hostname, int port, int timeout_milliseconds)
        {
            _hostname = hostname;
            _port = port;
            _timeout_milliseconds = timeout_milliseconds;
        }
        public TcpClient Connect()
        {
            // kick off the thread that tries to connect
            connected = false;
            exception = null;
            Thread thread = new Thread(new ThreadStart(BeginConnect));
            thread.IsBackground = true; // 作为后台线程处理
            // 不会占用机器太长的时间
            thread.Start();

            // 等待如下的时间
            thread.Join(_timeout_milliseconds);

            if (connected == true)
            {
                // 如果成功就返回TcpClient对象
                thread.Abort();
                return connection;
            }
            if (exception != null)
            {
                // 如果失败就抛出错误
                thread.Abort();
                throw exception;
            }
            else
            {
                // 同样地抛出错误
                thread.Abort();
                string message = string.Format("TcpClient connection to {0}:{1} timed out",
                  _hostname, _port);
                throw new TimeoutException(message);
            }
        }
        protected void BeginConnect()
        {
            try
            {
                connection = new TcpClient(_hostname, _port);
                // 标记成功，返回调用者
                connected = true;
            }
            catch (Exception ex)
            {
                // 标记失败
                exception = ex;
            }
        }
    }
}
