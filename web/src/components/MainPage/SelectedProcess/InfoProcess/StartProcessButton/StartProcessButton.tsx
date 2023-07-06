import { FC } from 'react'
import { CustomButton } from '../../../../CustomButton/CustomButton'
import { useAppSelector } from '../../../../../hooks/reduxHooks'
import { useMutation, useQueryClient } from '@tanstack/react-query'
import { startProcessApi } from '../../../../../api/startProcessApi'

const StartProcessButton: FC = () => {
	const openedProcessID = useAppSelector(state => state.processes.openedProcess)

	const queryClient = useQueryClient()
	const mutation = useMutation({
		mutationKey: [openedProcessID],
		mutationFn: startProcessApi.stopProcessId,
		onSuccess: () => {
			queryClient.invalidateQueries({ queryKey: ['processId'] })
			queryClient.invalidateQueries({ queryKey: ['allProcess'] })
		},
	})

	return (
		<CustomButton
			onClick={() => mutation.mutate(openedProcessID)}
			sx={{
				fontSize: {
					xs: '12px',
					lg: '14px',
				},
			}}
			variant='contained'
			endIcon={<img src='/completed.svg' height='20px' width='20px' />}
		>
			Запустить процесс
		</CustomButton>
	)
}

export default StartProcessButton