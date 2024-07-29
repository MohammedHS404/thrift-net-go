package main

import (
	"context"

	"github.com/apache/thrift/lib/go/thrift"
	"thift.com/calculator_service"
)

var ctx = context.Background()

func main() {
	server_port := "9090"
	server_host := "localhost"
	socket := thrift.NewTSocketConf(server_host+":"+server_port, &thrift.TConfiguration{})
	transportFactory := thrift.NewTBufferedTransportFactory(8192)
	protocolFactory := thrift.NewTBinaryProtocolFactoryConf(&thrift.TConfiguration{})
	transport, err := transportFactory.GetTransport(socket)
	client := calculator_service.NewCalculatorServiceClientFactory(transport, protocolFactory)

	if err != nil {
		panic(err)
	}
	transport.Open()
	res, err := client.Add(ctx, 1, 2)

	if err != nil {
		panic(err)
	}

	println(res)

	transport.Close()
}
