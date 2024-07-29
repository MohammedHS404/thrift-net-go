using Microsoft.Extensions.Logging;
using netstd;
using Thrift;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;
using Thrift.Transport.Server;

var serviceHandler=new CalculatorServiceHandler();

var processor = new CalculatorService.AsyncProcessor(serviceHandler);

TConfiguration configuration = new TConfiguration();

var transport = new TServerSocketTransport(9090,configuration,0);

var protocolFactory = new TBinaryProtocol.Factory();

var loggerFactory = new LoggerFactory();

var server=new TSimpleAsyncServer(processor:processor,serverTransport:transport,inputProtocolFactory:protocolFactory,outputProtocolFactory:protocolFactory,loggerFactory:loggerFactory);

await server.ServeAsync(CancellationToken.None);
