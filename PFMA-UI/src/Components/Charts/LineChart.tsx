import React, { PureComponent } from 'react';
import {
    LineChart,
    Line,
    XAxis,
    YAxis,
    CartesianGrid,
    Tooltip,
    Legend,
    ReferenceLine,
    ResponsiveContainer,
} from 'recharts';

const data = [
    {
        name: 'Jan',
        expense: 4000,
        saving: 2400,
        amt: 2400,
    },
    {
        name: 'Feb',
        expense: -3000,
        saving: 1398,
        amt: 2210,
    },
    {
        name: 'Mar',
        expense: -2000,
        saving: -9800,
        amt: 2290,
    },
    {
        name: 'Apr',
        expense: 2780,
        saving: 3908,
        amt: 2000,
    },
    {
        name: 'May',
        expense: -1890,
        saving: 4800,
        amt: 2181,
    },
    {
        name: 'Jun',
        expense: 2390,
        saving: -3800,
        amt: 2500,
    },
    {
        name: 'Jul',
        expense: 3490,
        saving: 4300,
        amt: 2100,
    },
];

export default class LineCharts extends PureComponent {
    render() {
        return (
            <ResponsiveContainer width="100%" height="100%">
                <LineChart
                    width={500}
                    height={300}
                    data={data}
                    margin={{
                        top: 20,
                        right: 50,
                        left: 20,
                        bottom: 5,
                    }}
                >
                    <CartesianGrid strokeDasharray="3 3" />
                    <XAxis dataKey="name" />
                    <YAxis />
                    <Tooltip />
                    <Legend />
                    <ReferenceLine y={0} stroke="red" />
                    <Line type="monotone" dataKey="saving" stroke="#3a923858" />
                    <Line type="monotone" dataKey="expense" stroke="#ff7b0058" />
                </LineChart>
            </ResponsiveContainer>
        );
    }
}